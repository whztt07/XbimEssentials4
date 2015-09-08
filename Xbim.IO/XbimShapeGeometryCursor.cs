﻿using Microsoft.Isam.Esent.Interop;

namespace Xbim.IO
{

    public class XbimShapeGeometryCursor : XbimCursor
    {
        #region Field Definition

        /// <summary>
        /// The unique label of this shape instance
        /// </summary>
        Int32ColumnValue _colValShapeLabel;
        /// <summary>
        /// The label of the IFC object that defines this shape
        /// </summary>
        Int32ColumnValue _colValIfcShapeLabel;
        /// <summary>
        ///  Hash of the shape Geometry, based on the IFC representation, this is not unique
        /// </summary>
        Int32ColumnValue _colValGeometryHash;
        /// <summary>
        /// The total cost in bytes of this shape
        /// </summary>
        Int32ColumnValue _colValCost;
        /// <summary>
        /// The number of references to this shape
        /// </summary>
        Int32ColumnValue _colValReferenceCount;
        /// <summary>
        /// The level of detail or development that the shape is suited for
        /// </summary>
        ByteColumnValue _colValLOD;
        /// <summary>
        /// The format in which the shape data is represented, i.e. triangular mesh, polygon, opencascade
        /// </summary>
        ByteColumnValue _colValFormat;
        /// <summary>
        /// The bounding box of this instance, requires tranformation to place in world coordinates
        /// </summary>
        BytesColumnValue _colValBoundingBox;
        /// <summary>
        /// The gemetry data defining the shape
        /// </summary>
        BytesColumnValue _colValShapeData;
        #endregion


        #region Constructors
        public XbimShapeGeometryCursor(XbimModel model, string database)
            : this(model, database, OpenDatabaseGrbit.None)
        {
        }
        public XbimShapeGeometryCursor(XbimModel model, string database, OpenDatabaseGrbit mode)
            : base(model, database, mode)
        {
            Api.JetOpenTable(this.sesid, this.dbId, GeometryTableName, null, 0, mode == OpenDatabaseGrbit.ReadOnly ? OpenTableGrbit.ReadOnly :
                                                                                mode == OpenDatabaseGrbit.Exclusive ? OpenTableGrbit.DenyWrite : OpenTableGrbit.None,
                                                                                out this.table);
            InitColumns();
        }
        #endregion
        

        #region Table defintion

        /// <summary>
        /// shape geometry table name
        /// </summary>
        public static string GeometryTableName = "ShapeGeometry";
        /// <summary>
        /// Index on the unique label
        /// </summary>
        const string geometryTablePrimaryIndex = "ShapeGeomPrimaryIndex";

        /// <summary>
        /// index on the geeometric hash
        /// </summary>
        const string geometryTableHashIndex = "ShapeGeomHashIndex";

        /// <summary>
        /// Index on the reference count
        /// </summary>
        const string geometryTableReferenceIndex = "ShapeGeomReferenceIndex";

        /// <summary>
        /// The unique label of this shape instance
        /// </summary>
        const string colNameShapeLabel = "ShapeGeomLabel";
        private JET_COLUMNID _colIdShapeLabel;

        /// <summary>
        /// The label of the IFC object that defines this shape
        /// </summary>
        const string colNameIfcShapeLabel = "ShapeGeomIfcLabel";
        private JET_COLUMNID _colIdIfcShapeLabel;

        /// <summary>
        /// The gemetry data defining the shape
        /// </summary>
        const string colNameShapeData = "ShapeGeomData";
        private JET_COLUMNID _colIdShapeData;

        /// <summary>
        ///  Hash of the shape Geometry, based on the IFC representation, this is not unique
        /// </summary>
        const string colNameGeometryHash = "ShapeGeomHash";
        private JET_COLUMNID _colIdGeometryHash;

        /// <summary>
        /// The cost in bytes of this shape
        /// </summary>
        const string colNameCost = "ShapeGeomCost";
        private JET_COLUMNID _colIdCost;
        /// <summary>
        /// The number of references to this shape
        /// </summary>
        const string colNameReferenceCount = "ShapeGeomReferenceCount";
        private JET_COLUMNID _colIdReferenceCount;

        /// <summary>
        /// The level of detail or development that the shape is suited for
        /// </summary>
        const string colNameLOD = "ShapeGeomLOD";
        private JET_COLUMNID _colIdLOD;

        /// <summary>
        /// The bounding box of this instance, requires tranformation to place in world coordinates
        /// </summary>
        const string colNameBoundingBox = "BoundingBox";
        private JET_COLUMNID _colIdBoundingBox;

        /// <summary>
        /// The format in which the shape data is represented, i.e. triangular mesh, polygon, opencascade
        /// </summary>
        const string colNameFormat = "ShapeGeomFormat";
        private JET_COLUMNID _colIdFormat;

        /// <summary>
        /// Holds all the table row values
        /// </summary>
        ColumnValue[] _colValues;

        private void InitColumns()
        {

            _colIdShapeLabel = Api.GetTableColumnid(sesid, table, colNameShapeLabel);
            _colIdIfcShapeLabel = Api.GetTableColumnid(sesid, table, colNameIfcShapeLabel);
            _colIdGeometryHash = Api.GetTableColumnid(sesid, table, colNameGeometryHash);
            _colIdCost = Api.GetTableColumnid(sesid, table, colNameCost);
            _colIdReferenceCount = Api.GetTableColumnid(sesid, table, colNameReferenceCount);
            _colIdLOD = Api.GetTableColumnid(sesid, table, colNameLOD);
            _colIdFormat = Api.GetTableColumnid(sesid, table, colNameFormat);
            _colIdBoundingBox = Api.GetTableColumnid(sesid, table, colNameBoundingBox);
            _colIdShapeData = Api.GetTableColumnid(sesid, table, colNameShapeData);

            _colValShapeLabel = new Int32ColumnValue { Columnid = _colIdShapeLabel };
            _colValIfcShapeLabel = new Int32ColumnValue { Columnid = _colIdIfcShapeLabel };
            _colValGeometryHash = new Int32ColumnValue { Columnid = _colIdGeometryHash };
            _colValCost = new Int32ColumnValue { Columnid = _colIdCost };
            _colValReferenceCount = new Int32ColumnValue { Columnid = _colIdReferenceCount };
            _colValLOD = new ByteColumnValue { Columnid = _colIdLOD };
            _colValFormat = new ByteColumnValue { Columnid = _colIdFormat };
            _colValBoundingBox = new BytesColumnValue { Columnid = _colIdBoundingBox };
            _colValShapeData = new BytesColumnValue { Columnid = _colIdShapeData }; 


            _colValues = new ColumnValue[] { _colValIfcShapeLabel, _colValGeometryHash, _colValCost, _colValReferenceCount, _colValLOD, _colValFormat,_colValBoundingBox,_colValShapeData };



        }
        #endregion

        #region Table Creation

        internal static void CreateTable(JET_SESID sesid, JET_DBID dbid)
        {
            JET_TABLEID tableid;
            Api.JetCreateTable(sesid, dbid, GeometryTableName, 8, 80, out tableid);

            using (var transaction = new Microsoft.Isam.Esent.Interop.Transaction(sesid))
            {
                JET_COLUMNID columnid;

                //Unique geometry label
                var columndef = new JET_COLUMNDEF
                {
                    coltyp = JET_coltyp.Long,
                    grbit = ColumndefGrbit.ColumnAutoincrement | ColumndefGrbit.ColumnNotNULL
                };
                Api.JetAddColumn(sesid, tableid, colNameShapeLabel, columndef, null, 0, out columnid);
                //IFC shape label
                columndef.coltyp = JET_coltyp.Long;
                columndef.grbit = ColumndefGrbit.ColumnNotNULL;
                Api.JetAddColumn(sesid, tableid, colNameIfcShapeLabel, columndef, null, 0, out columnid);
                //Geometry hash
                columndef.coltyp = JET_coltyp.Long;
                columndef.grbit = ColumndefGrbit.ColumnMaybeNull;
                Api.JetAddColumn(sesid, tableid, colNameGeometryHash, columndef, null, 0, out columnid);

                //cost
                columndef.coltyp = JET_coltyp.Long;
                columndef.grbit = ColumndefGrbit.ColumnNotNULL;
                Api.JetAddColumn(sesid, tableid, colNameCost, columndef, null, 0, out columnid);

                //reference count
                columndef.coltyp = JET_coltyp.Long;
                columndef.grbit = ColumndefGrbit.ColumnNotNULL;
                Api.JetAddColumn(sesid, tableid, colNameReferenceCount, columndef, null, 0, out columnid);
                //LOD
                columndef.coltyp = JET_coltyp.UnsignedByte;
                columndef.grbit = ColumndefGrbit.ColumnNotNULL;
                Api.JetAddColumn(sesid, tableid, colNameLOD, columndef, null, 0, out columnid);
              
                //Data format type
                columndef.coltyp = JET_coltyp.UnsignedByte;
                columndef.grbit = ColumndefGrbit.ColumnNotNULL;
                Api.JetAddColumn(sesid, tableid, colNameFormat, columndef, null, 0, out columnid);

                //Bounding Box data
                columndef.coltyp = JET_coltyp.Binary;
                columndef.grbit = ColumndefGrbit.ColumnNotNULL;
                Api.JetAddColumn(sesid, tableid, colNameBoundingBox, columndef, null, 0, out columnid);

                //Shape data
                columndef.coltyp = JET_coltyp.LongBinary;
                columndef.grbit = ColumndefGrbit.ColumnNotNULL;
                Api.JetAddColumn(sesid, tableid, colNameShapeData, columndef, null, 0, out columnid);

                // The primary index is the geometry label.
                string indexDef = string.Format("+{0}\0\0", colNameShapeLabel);
                Api.JetCreateIndex(sesid, tableid, geometryTablePrimaryIndex, CreateIndexGrbit.IndexPrimary|CreateIndexGrbit.IndexDisallowNull, indexDef, indexDef.Length, 100);

                //create index by geometry hashes    
                indexDef = string.Format("+{0}\0\0", colNameGeometryHash);
              //  Api.JetCreateIndex(sesid, tableid, geometryTableHashIndex, CreateIndexGrbit.None, indexDef, indexDef.Length, 100);

                //create indexfor reference count
                indexDef = string.Format("-{0}\0{1}\0{2}\0\0", colNameCost, colNameReferenceCount, colNameShapeLabel);
                Api.JetCreateIndex(sesid, tableid, geometryTableReferenceIndex, CreateIndexGrbit.None, indexDef, indexDef.Length, 100);

                Api.JetCloseTable(sesid, tableid);

                transaction.Commit(CommitTransactionGrbit.LazyFlush);
            }

        }
        #endregion

        #region Table operations
        /// <summary>
        /// Retrieve the count of geometry items in the database from the globals table.
        /// </summary>
        /// <returns>The number of items in the database.</returns>
        override internal int RetrieveCount()
        {
            return (int)Api.RetrieveColumnAsInt32(this.sesid, this.globalsTable, this.geometryCountColumn);
        }

        /// <summary>
        /// Update the count of geometry entities in the globals table. This is done with EscrowUpdate
        /// so that there won't be any write conflicts.
        /// </summary>
        /// <param name="delta">The delta to apply to the count.</param>
        override protected void UpdateCount(int delta)
        {
            Api.EscrowUpdate(this.sesid, this.globalsTable, this.geometryCountColumn, delta);
        }
        #endregion

        public int AddGeometry(IXbimShapeGeometryData shapeGeom)
        {
            int mainId = 0;
            
            using (var update = new Update(sesid, table, JET_prep.Insert))
            {
                _colValIfcShapeLabel.Value = shapeGeom.IfcShapeLabel;
                _colValGeometryHash.Value = shapeGeom.GeometryHash;
                _colValCost.Value = shapeGeom.Cost;
                _colValReferenceCount.Value = shapeGeom.ReferenceCount;
                _colValLOD.Value = shapeGeom.LOD;
                _colValFormat.Value = shapeGeom.Format;
                _colValShapeData.Value = shapeGeom.ShapeDataCompressed;
                _colValBoundingBox.Value = shapeGeom.BoundingBox;
                Api.SetColumns(sesid, table, _colValues);
                mainId = Api.RetrieveColumnAsInt32(sesid, table, _colIdShapeLabel, RetrieveColumnGrbit.RetrieveCopy).Value;
                update.Save();
                UpdateCount(1);
                shapeGeom.ShapeLabel = mainId;
            }
            
           
            return mainId;
        }

        public void UpdateReferenceCount(int geomLabel, int refCount)
        {
            Api.JetSetCurrentIndex(sesid, table, geometryTablePrimaryIndex);
            Api.MakeKey(sesid, table, geomLabel, MakeKeyGrbit.NewKey);
            if (Api.TrySeek(sesid, table, SeekGrbit.SeekEQ))
            {
                int size = Api.RetrieveColumnAsInt32(sesid, table, _colIdCost).Value;         
                using (var update = new Update(sesid, table, JET_prep.Replace))
                {
                    Api.SetColumn(sesid, table, _colIdCost, refCount*size); //set the total cost in bytes of this shape
                    Api.SetColumn(sesid, table, _colIdReferenceCount, refCount); //change the order variable to hold the number of references to this object
                    update.Save();
                }
            }
        }
        
        private void GetShapeGeometryData(IXbimShapeGeometryData sg)
        {
            Api.RetrieveColumns(sesid, table, _colValues);
            sg.ShapeLabel = Api.RetrieveColumnAsInt32(sesid, table, _colIdShapeLabel, RetrieveColumnGrbit.RetrieveFromIndex).Value;
            sg.IfcShapeLabel = _colValIfcShapeLabel.Value.Value;
            sg.GeometryHash = _colValGeometryHash.Value.Value;
            sg.ReferenceCount = _colValReferenceCount.Value.Value;
            sg.LOD = _colValLOD.Value.Value;
            sg.Format = _colValFormat.Value.Value;
            sg.ShapeDataCompressed = _colValShapeData.Value;
            sg.BoundingBox = _colValBoundingBox.Value;
        }

        /// <summary>
        /// Seeks and returns the first shape geometry
        /// </summary>
        /// <param name="sg"></param>
        public bool TryMoveFirstShapeGeometry(ref IXbimShapeGeometryData sg)
        {
            Api.JetSetCurrentIndex(sesid, table, geometryTablePrimaryIndex);
            if (TryMoveFirst())
            {
                GetShapeGeometryData(sg);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Returns the next Shape geometry after a move or a seek call
        /// </summary>
        /// <param name="sg"></param>
        /// <returns></returns>
        public bool TryMoveNextShapeGeometry(ref IXbimShapeGeometryData sg)
        {
            if (Api.TryMoveNext(this.sesid, this.table))
            {
                GetShapeGeometryData(sg);
                return true;
            }
            else
                return false;
        }

        
        /// <summary>
        /// Returns the shape geometry for the specified label if it exists
        /// </summary>
        /// <param name="shapeGeometryLabel"></param>
        /// <param name="sg"></param>
        /// <returns></returns>
        public bool TryGetShapeGeometry(int shapeGeometryLabel, ref IXbimShapeGeometryData sg)
        {
            Api.JetSetCurrentIndex(sesid, table, geometryTablePrimaryIndex);
            Api.MakeKey(sesid, table, shapeGeometryLabel, MakeKeyGrbit.NewKey);
            if (Api.TrySeek(sesid, table, SeekGrbit.SeekEQ))
            {
                GetShapeGeometryData(sg);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// fast retrieval of the reference counf for this geometry
        /// </summary>
        /// <param name="shapeGeometryLabel"></param>
        /// <returns></returns>
        public int GetReferenceCount(int shapeGeometryLabel)
        {
            Api.JetSetCurrentIndex(sesid, table, geometryTablePrimaryIndex);
            Api.MakeKey(sesid, table, shapeGeometryLabel, MakeKeyGrbit.NewKey);
            if (Api.TrySeek(sesid, table, SeekGrbit.SeekEQ))
            {
                int refCount = Api.RetrieveColumnAsInt32(sesid, table, _colIdReferenceCount,RetrieveColumnGrbit.RetrieveFromIndex).Value;
                return refCount;
            }
            return 0;
        }

        /// <summary>
        /// Moves to the first Shape Geometry and sets the index to the reference counter index
        /// </summary>
        /// <returns></returns>
        public bool TryMoveFirstReferenceCounter()
        {
            Api.JetSetCurrentIndex(sesid, table, geometryTableReferenceIndex);
            return TryMoveFirst();
        }


        /// <summary> Moves to the next shape geometry assumes TryMoveFirstReferenceCounter has been called
        /// 
        /// </summary>
        /// <returns></returns>
        public bool TryMoveNextReferenceCounter()
        {
            return TryMoveNext();
        }
       
        /// <summary>
        /// returns the reference count for the current record, assume that TryMoveFirstReferenceCounter has been called
        /// </summary>
        /// <returns></returns>
        public int GetReferenceCount()
        {
            return Api.RetrieveColumnAsInt32(sesid, table, _colIdReferenceCount, RetrieveColumnGrbit.RetrieveFromIndex).Value;
        }

        /// <summary>
        /// returns the cost for the current record, assume that TryMoveFirstReferenceCounter has been called
        /// </summary>
        /// <returns></returns>
        public int GetCost()
        {
            return Api.RetrieveColumnAsInt32(sesid, table, _colIdCost, RetrieveColumnGrbit.RetrieveFromIndex).Value;
        }
        /// <summary>
        /// returns the geometry label for the current record, assume that the current index has been set to primary
        /// </summary>
        /// <returns></returns>
        public int GetShapeGeometryLabel()
        {
            return Api.RetrieveColumnAsInt32(sesid, table, _colIdShapeLabel, RetrieveColumnGrbit.RetrieveFromIndex).Value;
        }
    }
}
