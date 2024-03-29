//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Mapping.EntityViewGenerationAttribute(typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets055905C7433EFF9F6AD29454C2E2B2F927DF2C6B9FCDD55612E633B863188CFB))]

namespace Edm_EntityMappingGeneratedViews
{
    
    
    /// <Summary>
    /// The type contains views for EntitySets and AssociationSets that were generated at design time.
    /// </Summary>
    public sealed class ViewsForBaseEntitySets055905C7433EFF9F6AD29454C2E2B2F927DF2C6B9FCDD55612E633B863188CFB : System.Data.Mapping.EntityViewContainer
    {
        
        /// <Summary>
        /// The constructor stores the views for the extents and also the hash values generated based on the metadata and mapping closure and views.
        /// </Summary>
        public ViewsForBaseEntitySets055905C7433EFF9F6AD29454C2E2B2F927DF2C6B9FCDD55612E633B863188CFB()
        {
            this.EdmEntityContainerName = "ModelContext";
            this.StoreEntityContainerName = "CodeFirstDatabase";
            this.HashOverMappingClosure = "22d766e7d517634933c600596a488befcee48711316a43fd5a26eebd06a46b8c";
            this.HashOverAllExtentViews = "2cf1d7fd26c086713d9327a8cd3e9741916cbc2cbf6d27178c680aaa74169c83";
            this.ViewCount = 2;
        }
        
        /// <Summary>
        /// The method returns the view for the index given.
        /// </Summary>
        protected override System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index)
        {
            if ((index == 0))
            {
                return GetView0();
            }
            if ((index == 1))
            {
                return GetView1();
            }
            throw new System.IndexOutOfRangeException();
        }
        
        /// <Summary>
        /// return view for CodeFirstDatabase.Client
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView0()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("CodeFirstDatabase.Client", @"
    SELECT VALUE -- Constructing Client
        [CodeFirstDatabaseSchema.Client](T1.Client_ID, T1.Client_FullName, T1.Client_Gender, T1.Client_PlaceOfBirth, T1.Client_DateOfBirth)
    FROM (
        SELECT 
            T.ID AS Client_ID, 
            T.FullName AS Client_FullName, 
            T.Gender AS Client_Gender, 
            T.PlaceOfBirth AS Client_PlaceOfBirth, 
            T.DateOfBirth AS Client_DateOfBirth, 
            True AS _from0
        FROM ModelContext.Client AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for ModelContext.Client
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView1()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("ModelContext.Client", @"
    SELECT VALUE -- Constructing Client
        [CRUD.Models.Client](T1.Client_ID, T1.Client_FullName, T1.Client_Gender, T1.Client_PlaceOfBirth, T1.Client_DateOfBirth)
    FROM (
        SELECT 
            T.ID AS Client_ID, 
            T.FullName AS Client_FullName, 
            T.Gender AS Client_Gender, 
            T.PlaceOfBirth AS Client_PlaceOfBirth, 
            T.DateOfBirth AS Client_DateOfBirth, 
            True AS _from0
        FROM CodeFirstDatabase.Client AS T
    ) AS T1");
        }
    }
}
