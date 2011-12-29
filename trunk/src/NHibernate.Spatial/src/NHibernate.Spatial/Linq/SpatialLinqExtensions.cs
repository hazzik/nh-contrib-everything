using GeoAPI.Geometries;

namespace NHibernate.Spatial.Linq
{
	public static class SpatialLinqExtensions
	{
		public static int GetDimension(this IGeometry geometry)
		{ throw new SpatialLinqMethodException(); }	
		
		public static IGeometry Simplify(this IGeometry geometry, double distance)
		{ throw new SpatialLinqMethodException(); }	

		public static IGeometry Transform(this IGeometry geometry, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IGeometryCollection ToGeometryCollection(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IGeometryCollection ToGeometryCollection(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IGeometry ToGeometry(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IGeometry ToGeometry(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static ILineString ToLineString(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static ILineString ToLineString(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IPoint ToPoint(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }

		public static IPoint ToPoint(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IPolygon ToPolygon(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IPolygon ToPolygon(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IMultiLineString ToMultiLineString(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IMultiLineString ToMultiLineString(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IMultiPoint ToMultiPoint(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }

		public static IMultiPoint ToMultiPoint(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	

		public static IMultiPolygon ToMultiPolygon(this string text, int srid)
		{ throw new SpatialLinqMethodException(); }

		public static IMultiPolygon ToMultiPolygon(this byte[] wkb, int srid)
		{ throw new SpatialLinqMethodException(); }	
	
	}
}