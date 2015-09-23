﻿using System.Linq;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.SharedBldgElements;
using Xbim.IO.Esent;

namespace Xbim.IO
{
    public class XbimModelSummary
    {
        readonly EsentModel _model;

        public XbimModelSummary(EsentModel model)
        {
            _model = model;
        }

        public string SchemaVersion
        {
            get { return _model.Header.SchemaVersion; }
        }

        public string FileTitle
        {
            get { return _model.Header.FileName.Name; }
        }

        public string TimeStamp
        {
            get { return _model.Header.FileName.TimeStamp; }
        }

        public string OriginatingSystem
        {
            get { return _model.Header.FileName.OriginatingSystem; }
        }

        public string IFCProcessor
        {
            get { return _model.Header.FileName.PreprocessorVersion; }
        }

        public string ViewDefinition
        {
            get { return string.Join(",",_model.Header.FileDescription.Description); }
        }

        public string ProjectName
        {
            get
            {
                return  _model.IfcProject.FriendlyName; 
            }
        }

        public string SiteAddress
        {
            get
            {
                var site =  _model.Instances.OfType<IfcSite>().FirstOrDefault();
                if (site != null && site.SiteAddress != null)
                    return string.Join(",",site.SiteAddress.SummaryString());
                return "";
            }
        }
        public long StoreyCount
        {
            get
            {
                return _model.Instances.CountOf<IfcBuildingStorey>();
            }
        }

        //TODO: Uncomment once this functionality is moved out from Xbim.IO
        //public double GrossFloorArea
        //{
        //    get
        //    {
        //        double area = 0;
        //        foreach (var building in _model.Instances.OfType<IfcBuilding>())
        //        {
        //            IfcAreaMeasure? a = building.GetGrossFloorArea();
        //            if (a.HasValue) area += a.Value;
        //        }
        //        return area;
        //    }
        //}

        public long BuildingElementCount
        {
            get
            {
                return _model.Instances.CountOf<IfcBuildingElement>();
            }
        }

        public long FurnishingElementCount
        {
            get
            {
                return _model.Instances.CountOf<IfcFurnishingElement>();
            }
        }

        public long ElectricalElementCount
        {
            get
            {
                return _model.Instances.CountOf<IfcElectricalElement>();
            }
        }

        public long DistributionElementCount
        {
            get
            {
                return _model.Instances.CountOf<IfcDistributionElement>();
            }
        }

        public long ParticipantCount
        {
            get
            {
                return _model.Instances.CountOf<IfcActor>();
            }
        }

        public long DoorCount
        {
            get
            {
                return _model.Instances.CountOf<IfcDoor>();
            }
        }

        public long WindowCount
        {
            get
            {
                return _model.Instances.CountOf<IfcWindow>();
            }
        }

        public long SpaceCount
        {
            get
            {
                return _model.Instances.CountOf<IfcSpace>();
            }
        }
    }
}
