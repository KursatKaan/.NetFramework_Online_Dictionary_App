﻿// <auto-generated />
namespace Blog.DataLayer.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.4")]
    public sealed partial class add_Message_IsDraft : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(add_Message_IsDraft));
        
        string IMigrationMetadata.Id
        {
            get { return "202311162316111_add_Message_IsDraft"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
