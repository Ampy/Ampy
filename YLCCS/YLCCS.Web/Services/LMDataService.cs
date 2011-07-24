
namespace YLCCS.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using YLCCS.Web.Models;


    // Implements application logic using the YLDBEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class LMDataService : LinqToEntitiesDomainService<YLDBEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Aerobic' query.
        [Query(IsDefault = true)]
        public IQueryable<Aerobic> GetAerobic()
        {
            return this.ObjectContext.Aerobic;
        }

        public void InsertAerobic(Aerobic aerobic)
        {
            if ((aerobic.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(aerobic, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Aerobic.AddObject(aerobic);
            }
        }

        public void UpdateAerobic(Aerobic currentAerobic)
        {
            this.ObjectContext.Aerobic.AttachAsModified(currentAerobic, this.ChangeSet.GetOriginal(currentAerobic));
        }

        public void DeleteAerobic(Aerobic aerobic)
        {
            if ((aerobic.EntityState == EntityState.Detached))
            {
                this.ObjectContext.Aerobic.Attach(aerobic);
            }
            this.ObjectContext.Aerobic.DeleteObject(aerobic);
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'BasicData' query.
        [Query(IsDefault = true)]
        public IQueryable<BasicData> GetBasicData()
        {
            return this.ObjectContext.BasicData;
        }

        public void InsertBasicData(BasicData basicData)
        {
            if ((basicData.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(basicData, EntityState.Added);
            }
            else
            {
                this.ObjectContext.BasicData.AddObject(basicData);
            }
        }

        public void UpdateBasicData(BasicData currentBasicData)
        {
            this.ObjectContext.BasicData.AttachAsModified(currentBasicData, this.ChangeSet.GetOriginal(currentBasicData));
        }

        public void DeleteBasicData(BasicData basicData)
        {
            if ((basicData.EntityState == EntityState.Detached))
            {
                this.ObjectContext.BasicData.Attach(basicData);
            }
            this.ObjectContext.BasicData.DeleteObject(basicData);
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Strength' query.
        [Query(IsDefault = true)]
        public IQueryable<Strength> GetStrength()
        {
            return this.ObjectContext.Strength;
        }

        public void InsertStrength(Strength strength)
        {
            if ((strength.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(strength, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Strength.AddObject(strength);
            }
        }

        public void UpdateStrength(Strength currentStrength)
        {
            this.ObjectContext.Strength.AttachAsModified(currentStrength, this.ChangeSet.GetOriginal(currentStrength));
        }

        public void DeleteStrength(Strength strength)
        {
            if ((strength.EntityState == EntityState.Detached))
            {
                this.ObjectContext.Strength.Attach(strength);
            }
            this.ObjectContext.Strength.DeleteObject(strength);
        }
    }
}


