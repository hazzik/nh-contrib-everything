﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;


namespace NHibernate.NHDesigner
{
	/// <summary>
	/// DomainModel NHDesignerDomainModel
	/// Description for NHibernate.NHDesigner.NHDesigner
	/// </summary>
	[DslDesign::DisplayNameResource("NHibernate.NHDesigner.NHDesignerDomainModel.DisplayName", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NHibernate.NHDesigner.NHDesignerDomainModel.Description", typeof(global::NHibernate.NHDesigner.NHDesignerDomainModel), "NHibernate.NHDesigner.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("ceaa11bc-3019-4591-8631-cd3c8cdf743d")]
	public partial class NHDesignerDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// NHDesignerDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0xceaa11bc, 0x3019, 0x4591, 0x86, 0x31, 0xcd, 0x3c, 0x8c, 0xdf, 0x74, 0x3d);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public NHDesignerDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
		}
		
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(NHibernateModel),
				typeof(Entity),
				typeof(Property),
				typeof(NHibernateModelHasEntities),
				typeof(EntityReferencesBase),
				typeof(EntityHasProperties),
				typeof(EntityReferencesBaseWithJoin),
				typeof(NHDesignerDiagram),
				typeof(SubclassConnector),
				typeof(JoinedSubclassConnector),
				typeof(EntityShape),
				typeof(global::NHibernate.NHDesigner.FixUpDiagram),
				typeof(global::NHibernate.NHDesigner.ConnectorRolePlayerChanged),
				typeof(global::NHibernate.NHDesigner.CompartmentItemAddRule),
				typeof(global::NHibernate.NHDesigner.CompartmentItemDeleteRule),
				typeof(global::NHibernate.NHDesigner.CompartmentItemRolePlayerChangeRule),
				typeof(global::NHibernate.NHDesigner.CompartmentItemRolePlayerPositionChangeRule),
				typeof(global::NHibernate.NHDesigner.CompartmentItemChangeRule),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(Entity), "Name", Entity.NameDomainPropertyId, typeof(Entity.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Property), "Name", Property.NameDomainPropertyId, typeof(Property.NamePropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(NHibernateModelHasEntities), "NHibernateModel", NHibernateModelHasEntities.NHibernateModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(NHibernateModelHasEntities), "Element", NHibernateModelHasEntities.ElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityReferencesBase), "Source", EntityReferencesBase.SourceDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityReferencesBase), "Target", EntityReferencesBase.TargetDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasProperties), "Entity", EntityHasProperties.EntityDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasProperties), "Property", EntityHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityReferencesBaseWithJoin), "SourceEntity", EntityReferencesBaseWithJoin.SourceEntityDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityReferencesBaseWithJoin), "TargetEntity", EntityReferencesBaseWithJoin.TargetEntityDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(7);
				createElementMap.Add(typeof(NHibernateModel), 0);
				createElementMap.Add(typeof(Entity), 1);
				createElementMap.Add(typeof(Property), 2);
				createElementMap.Add(typeof(NHDesignerDiagram), 3);
				createElementMap.Add(typeof(SubclassConnector), 4);
				createElementMap.Add(typeof(JoinedSubclassConnector), 5);
				createElementMap.Add(typeof(EntityShape), 6);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::NHibernate.NHDesigner.NHDesignerDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new NHibernateModel(partition, propertyAssignments);
				case 1: return new Entity(partition, propertyAssignments);
				case 2: return new Property(partition, propertyAssignments);
				case 3: return new NHDesignerDiagram(partition, propertyAssignments);
				case 4: return new SubclassConnector(partition, propertyAssignments);
				case 5: return new JoinedSubclassConnector(partition, propertyAssignments);
				case 6: return new EntityShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(4);
				createElementLinkMap.Add(typeof(NHibernateModelHasEntities), 0);
				createElementLinkMap.Add(typeof(EntityReferencesBase), 1);
				createElementLinkMap.Add(typeof(EntityHasProperties), 2);
				createElementLinkMap.Add(typeof(EntityReferencesBaseWithJoin), 3);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::NHibernate.NHDesigner.NHDesignerDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new NHibernateModelHasEntities(partition, roleAssignments, propertyAssignments);
				case 1: return new EntityReferencesBase(partition, roleAssignments, propertyAssignments);
				case 2: return new EntityHasProperties(partition, roleAssignments, propertyAssignments);
				case 3: return new EntityReferencesBaseWithJoin(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "NHibernate.NHDesigner.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return NHDesignerDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (NHDesignerDomainModel.resourceManager == null)
				{
					NHDesignerDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(NHDesignerDomainModel).Assembly);
				}
				return NHDesignerDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return NHDesignerDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return NHDesignerDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (NHDesignerDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new NHDesignerCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					NHDesignerDomainModel.copyClosure = copyFilter;
				}
				return NHDesignerDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (NHDesignerDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new NHDesignerDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					NHDesignerDomainModel.removeClosure = removeFilter;
				}
				return NHDesignerDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::NHibernate.NHDesigner.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::NHibernate.NHDesigner.ConnectorRolePlayerChanged));
			ruleManager.EnableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemAddRule));
			ruleManager.EnableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemDeleteRule));
			ruleManager.EnableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemRolePlayerChangeRule));
			ruleManager.EnableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.EnableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemChangeRule));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::NHibernate.NHDesigner.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::NHibernate.NHDesigner.ConnectorRolePlayerChanged));
			ruleManager.DisableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemAddRule));
			ruleManager.DisableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemDeleteRule));
			ruleManager.DisableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemRolePlayerChangeRule));
			ruleManager.DisableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.DisableRule(typeof(global::NHibernate.NHDesigner.CompartmentItemChangeRule));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class NHDesignerDeleteClosure : NHDesignerDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NHDesignerDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	public partial class NHDesignerDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public NHDesignerDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::NHibernate.NHDesigner.NHibernateModelHasEntities.ElementDomainRoleId, true);
			DomainRoles.Add(global::NHibernate.NHDesigner.EntityHasProperties.PropertyDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class NHDesignerCopyClosure : NHDesignerCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NHDesignerCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	public partial class NHDesignerCopyClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public NHDesignerCopyClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::NHibernate.NHDesigner.EntityHasProperties.PropertyDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			if (sourceRoleInfo == null) throw new global::System.ArgumentNullException("sourceRoleInfo");
			return this.DomainRoles.Contains(sourceRoleInfo.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	#endregion
		
}

