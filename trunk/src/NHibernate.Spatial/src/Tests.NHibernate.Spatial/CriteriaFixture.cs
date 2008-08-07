using System;
using System.Collections;
using GisSharpBlog.NetTopologySuite.Geometries;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Spatial.Criterion;
using NUnit.Framework;
using Tests.NHibernate.Spatial.Model;

namespace Tests.NHibernate.Spatial
{
	public abstract class CriteriaFixture : AbstractFixture
	{
		protected override Type[] Mappings
		{
			get
			{
				return new Type[] { 
					typeof(Simple)
				};
			}
		}

		private ISession session;

		protected override void OnSetUp()
		{
			session = sessions.OpenSession();

			session.Save(new Simple("a point", new Point(123, 456)));
			session.Save(new Simple("a null", null));
			session.Save(new Simple("a collection empty 1", Wkt.Read("GEOMETRYCOLLECTION EMPTY")));
			session.Save(new Simple("a collection empty 2", GeometryCollection.Empty));
			session.Flush();
		}

		protected override void OnTearDown()
		{
			DeleteMappings(session);
			session.Close();
		}

		[Test]
		public void RowCount()
		{
			IList results = session.CreateCriteria(typeof(Simple))
				.SetProjection(Projections.ProjectionList()
					.Add(Projections.RowCount())
					)
				.List();

			Assert.AreEqual(4, (int)(results[0]));
		}

		[Test]
		public void CountNullOrSpatialEmpty()
		{
			IList results = session.CreateCriteria(typeof(Simple))
				.Add(Expression.Or(
					Expression.IsNull("Geometry"),
					SpatialExpression.IsEmpty("Geometry")
				))
				.List();
			Assert.AreEqual(3, results.Count);
			foreach (Simple item in results)
			{
				if (item.Geometry != null)
				{
					Assert.IsTrue(item.Geometry.IsEmpty);
				}
			}
		}

		[Test]
		public void CountNull()
		{
			IList results = session.CreateCriteria(typeof(Simple))
				.Add(Expression.IsNull("Geometry"))
				.List();
			Assert.AreEqual(1, results.Count);
			foreach (Simple item in results)
			{
				Assert.IsNull(item.Geometry);
			}
		}

		[Test]
		[ExpectedException(typeof(MappingException))]
		public void CountEmpty()
		{
			IList results = session.CreateCriteria(typeof(Simple))
				.Add(Expression.IsEmpty("Geometry"))
				.List();
			Assert.AreEqual(0, results.Count);
		}

		[Test]
		public void CountSpatialEmpty()
		{
			IList results = session.CreateCriteria(typeof(Simple))
				.Add(SpatialExpression.IsEmpty("Geometry"))
				.List();
			Assert.AreEqual(2, results.Count);
			foreach (Simple item in results)
			{
				Assert.IsTrue(item.Geometry.IsEmpty);
			}
		}
	}
}
