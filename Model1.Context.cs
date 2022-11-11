﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbOkul
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db_okulEntities : DbContext
    {
        public db_okulEntities()
            : base("name=db_okulEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bolum> bolum { get; set; }
        public virtual DbSet<ders> ders { get; set; }
        public virtual DbSet<ogrenci> ogrenci { get; set; }
        public virtual DbSet<ogrenci_ders> ogrenci_ders { get; set; }
        public virtual DbSet<ogretmen> ogretmen { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        [DbFunction("db_okulEntities", "fn_aciklama")]
        public virtual IQueryable<fn_aciklama_Result> fn_aciklama(Nullable<int> vbolid)
        {
            var vbolidParameter = vbolid.HasValue ?
                new ObjectParameter("vbolid", vbolid) :
                new ObjectParameter("vbolid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_aciklama_Result>("[db_okulEntities].[fn_aciklama](@vbolid)", vbolidParameter);
        }
    
        [DbFunction("db_okulEntities", "fn_not")]
        public virtual IQueryable<fn_not_Result> fn_not(Nullable<int> dersnotu)
        {
            var dersnotuParameter = dersnotu.HasValue ?
                new ObjectParameter("dersnotu", dersnotu) :
                new ObjectParameter("dersnotu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_not_Result>("[db_okulEntities].[fn_not](@dersnotu)", dersnotuParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int spbolumekle(Nullable<int> vbid, string vbadi, string vaciklama, string veposta)
        {
            var vbidParameter = vbid.HasValue ?
                new ObjectParameter("vbid", vbid) :
                new ObjectParameter("vbid", typeof(int));
    
            var vbadiParameter = vbadi != null ?
                new ObjectParameter("vbadi", vbadi) :
                new ObjectParameter("vbadi", typeof(string));
    
            var vaciklamaParameter = vaciklama != null ?
                new ObjectParameter("vaciklama", vaciklama) :
                new ObjectParameter("vaciklama", typeof(string));
    
            var vepostaParameter = veposta != null ?
                new ObjectParameter("veposta", veposta) :
                new ObjectParameter("veposta", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spbolumekle", vbidParameter, vbadiParameter, vaciklamaParameter, vepostaParameter);
        }
    
        public virtual int spdersekle(Nullable<int> vdid, string vdadi, string vdkodu, Nullable<int> vkredi, Nullable<int> vbid)
        {
            var vdidParameter = vdid.HasValue ?
                new ObjectParameter("vdid", vdid) :
                new ObjectParameter("vdid", typeof(int));
    
            var vdadiParameter = vdadi != null ?
                new ObjectParameter("vdadi", vdadi) :
                new ObjectParameter("vdadi", typeof(string));
    
            var vdkoduParameter = vdkodu != null ?
                new ObjectParameter("vdkodu", vdkodu) :
                new ObjectParameter("vdkodu", typeof(string));
    
            var vkrediParameter = vkredi.HasValue ?
                new ObjectParameter("vkredi", vkredi) :
                new ObjectParameter("vkredi", typeof(int));
    
            var vbidParameter = vbid.HasValue ?
                new ObjectParameter("vbid", vbid) :
                new ObjectParameter("vbid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spdersekle", vdidParameter, vdadiParameter, vdkoduParameter, vkrediParameter, vbidParameter);
        }
    
        public virtual int spogrenciekle(Nullable<int> vono, string vadi, string vsoyadi, string vdyeri, Nullable<int> vbid)
        {
            var vonoParameter = vono.HasValue ?
                new ObjectParameter("vono", vono) :
                new ObjectParameter("vono", typeof(int));
    
            var vadiParameter = vadi != null ?
                new ObjectParameter("vadi", vadi) :
                new ObjectParameter("vadi", typeof(string));
    
            var vsoyadiParameter = vsoyadi != null ?
                new ObjectParameter("vsoyadi", vsoyadi) :
                new ObjectParameter("vsoyadi", typeof(string));
    
            var vdyeriParameter = vdyeri != null ?
                new ObjectParameter("vdyeri", vdyeri) :
                new ObjectParameter("vdyeri", typeof(string));
    
            var vbidParameter = vbid.HasValue ?
                new ObjectParameter("vbid", vbid) :
                new ObjectParameter("vbid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spogrenciekle", vonoParameter, vadiParameter, vsoyadiParameter, vdyeriParameter, vbidParameter);
        }
    
        public virtual int spogretmenekle(Nullable<int> @void, string vadi, string vsoyadi, string vdyeri, Nullable<int> vbid)
        {
            var voidParameter = @void.HasValue ?
                new ObjectParameter("void", @void) :
                new ObjectParameter("void", typeof(int));
    
            var vadiParameter = vadi != null ?
                new ObjectParameter("vadi", vadi) :
                new ObjectParameter("vadi", typeof(string));
    
            var vsoyadiParameter = vsoyadi != null ?
                new ObjectParameter("vsoyadi", vsoyadi) :
                new ObjectParameter("vsoyadi", typeof(string));
    
            var vdyeriParameter = vdyeri != null ?
                new ObjectParameter("vdyeri", vdyeri) :
                new ObjectParameter("vdyeri", typeof(string));
    
            var vbidParameter = vbid.HasValue ?
                new ObjectParameter("vbid", vbid) :
                new ObjectParameter("vbid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spogretmenekle", voidParameter, vadiParameter, vsoyadiParameter, vdyeriParameter, vbidParameter);
        }
    }
}