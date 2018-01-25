using System;
using System.Collections.Generic;
using MoServiceTracking.Models;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MoServiceTracking.Persistence.EntityConfigurations
{
    public class StageConfiguration:EntityTypeConfiguration<Transaction>
    {
        public StageConfiguration()
        {
            /*HasMany(s => s.Services)
                .WithMany(sv => sv.Stages)
                .Map(ssv => ssv.
                            ToTable("ServiceStages")
                            .MapLeftKey("StageId")
                            .MapRightKey("ServiceId"));*/
        }
        
    }
}