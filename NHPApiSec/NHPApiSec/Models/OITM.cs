using System;
using System.Collections.Generic;

namespace NHPApi.Models
{
    //public partial class OITM
    //{

    //    public string ItemCode { get; set; }
    //    public string ItemName { get; set; }
    //    public string FrgnName { get; set; }
    //    public Nullable<short> ItmsGrpCod { get; set; }
    //    public Nullable<short> CstGrpCode { get; set; }
    //    public string VatGourpSa { get; set; }
    //    public string CodeBars { get; set; }
    //    public string VATLiable { get; set; }
    //    public string PrchseItem { get; set; }
    //    public string SellItem { get; set; }
    //    public string InvntItem { get; set; }
    //    public Nullable<decimal> OnHand { get; set; }
    //    public Nullable<decimal> IsCommited { get; set; }
    //    public Nullable<decimal> OnOrder { get; set; }
    //    public string IncomeAcct { get; set; }
    //    public string ExmptIncom { get; set; }
    //    public Nullable<decimal> MaxLevel { get; set; }
    //    public string DfltWH { get; set; }
    //    public string CardCode { get; set; }
    //    public string SuppCatNum { get; set; }
    //    public string BuyUnitMsr { get; set; }
    //    public Nullable<decimal> NumInBuy { get; set; }
    //    public Nullable<decimal> ReorderQty { get; set; }
    //    public Nullable<decimal> MinLevel { get; set; }
    //    public Nullable<decimal> LstEvlPric { get; set; }
    //    public Nullable<System.DateTime> LstEvlDate { get; set; }
    //    public Nullable<decimal> CustomPer { get; set; }
    //    public string Canceled { get; set; }
    //    public Nullable<int> MnufctTime { get; set; }
    //    public string WholSlsTax { get; set; }
    //    public string RetilrTax { get; set; }
    //    public Nullable<decimal> SpcialDisc { get; set; }
    //    public Nullable<short> DscountCod { get; set; }
    //    public string TrackSales { get; set; }
    //    public string SalUnitMsr { get; set; }
    //    public Nullable<decimal> NumInSale { get; set; }
    //    public Nullable<decimal> Consig { get; set; }
    //    public Nullable<int> QueryGroup { get; set; }
    //    public Nullable<decimal> Counted { get; set; }
    //    public Nullable<decimal> OpenBlnc { get; set; }
    //    public string EvalSystem { get; set; }
    //    public Nullable<short> UserSign { get; set; }
    //    public string FREE { get; set; }
    //    public string PicturName { get; set; }
    //    public string Transfered { get; set; }
    //    public string BlncTrnsfr { get; set; }
    //    public string UserText { get; set; }
    //    public string SerialNum { get; set; }
    //    public Nullable<decimal> CommisPcnt { get; set; }
    //    public Nullable<decimal> CommisSum { get; set; }
    //    public Nullable<short> CommisGrp { get; set; }
    //    public string TreeType { get; set; }
    //    public Nullable<decimal> TreeQty { get; set; }
    //    public Nullable<decimal> LastPurPrc { get; set; }
    //    public string LastPurCur { get; set; }
    //    public Nullable<System.DateTime> LastPurDat { get; set; }
    //    public string ExitCur { get; set; }
    //    public Nullable<decimal> ExitPrice { get; set; }
    //    public string ExitWH { get; set; }
    //    public string AssetItem { get; set; }
    //    public string WasCounted { get; set; }
    //    public string ManSerNum { get; set; }
    //    public Nullable<decimal> SHeight1 { get; set; }
    //    public Nullable<short> SHght1Unit { get; set; }
    //    public Nullable<decimal> SHeight2 { get; set; }
    //    public Nullable<short> SHght2Unit { get; set; }
    //    public Nullable<decimal> SWidth1 { get; set; }
    //    public Nullable<short> SWdth1Unit { get; set; }
    //    public Nullable<decimal> SWidth2 { get; set; }
    //    public Nullable<short> SWdth2Unit { get; set; }
    //    public Nullable<decimal> SLength1 { get; set; }
    //    public Nullable<short> SLen1Unit { get; set; }
    //    public Nullable<decimal> Slength2 { get; set; }
    //    public Nullable<short> SLen2Unit { get; set; }
    //    public Nullable<decimal> SVolume { get; set; }
    //    public Nullable<short> SVolUnit { get; set; }
    //    public Nullable<decimal> SWeight1 { get; set; }
    //    public Nullable<short> SWght1Unit { get; set; }
    //    public Nullable<decimal> SWeight2 { get; set; }
    //    public Nullable<short> SWght2Unit { get; set; }
    //    public Nullable<decimal> BHeight1 { get; set; }
    //    public Nullable<short> BHght1Unit { get; set; }
    //    public Nullable<decimal> BHeight2 { get; set; }
    //    public Nullable<short> BHght2Unit { get; set; }
    //    public Nullable<decimal> BWidth1 { get; set; }
    //    public Nullable<short> BWdth1Unit { get; set; }
    //    public Nullable<decimal> BWidth2 { get; set; }
    //    public Nullable<short> BWdth2Unit { get; set; }
    //    public Nullable<decimal> BLength1 { get; set; }
    //    public Nullable<short> BLen1Unit { get; set; }
    //    public Nullable<decimal> Blength2 { get; set; }
    //    public Nullable<short> BLen2Unit { get; set; }
    //    public Nullable<decimal> BVolume { get; set; }
    //    public Nullable<short> BVolUnit { get; set; }
    //    public Nullable<decimal> BWeight1 { get; set; }
    //    public Nullable<short> BWght1Unit { get; set; }
    //    public Nullable<decimal> BWeight2 { get; set; }
    //    public Nullable<short> BWght2Unit { get; set; }
    //    public string FixCurrCms { get; set; }
    //    public Nullable<short> FirmCode { get; set; }
    //    public Nullable<System.DateTime> LstSalDate { get; set; }
    //    public string QryGroup1 { get; set; }
    //    public string QryGroup2 { get; set; }
    //    public string QryGroup3 { get; set; }
    //    public string QryGroup4 { get; set; }
    //    public string QryGroup5 { get; set; }
    //    public string QryGroup6 { get; set; }
    //    public string QryGroup7 { get; set; }
    //    public string QryGroup8 { get; set; }
    //    public string QryGroup9 { get; set; }
    //    public string QryGroup10 { get; set; }
    //    public string QryGroup11 { get; set; }
    //    public string QryGroup12 { get; set; }
    //    public string QryGroup13 { get; set; }
    //    public string QryGroup14 { get; set; }
    //    public string QryGroup15 { get; set; }
    //    public string QryGroup16 { get; set; }
    //    public string QryGroup17 { get; set; }
    //    public string QryGroup18 { get; set; }
    //    public string QryGroup19 { get; set; }
    //    public string QryGroup20 { get; set; }
    //    public string QryGroup21 { get; set; }
    //    public string QryGroup22 { get; set; }
    //    public string QryGroup23 { get; set; }
    //    public string QryGroup24 { get; set; }
    //    public string QryGroup25 { get; set; }
    //    public string QryGroup26 { get; set; }
    //    public string QryGroup27 { get; set; }
    //    public string QryGroup28 { get; set; }
    //    public string QryGroup29 { get; set; }
    //    public string QryGroup30 { get; set; }
    //    public string QryGroup31 { get; set; }
    //    public string QryGroup32 { get; set; }
    //    public string QryGroup33 { get; set; }
    //    public string QryGroup34 { get; set; }
    //    public string QryGroup35 { get; set; }
    //    public string QryGroup36 { get; set; }
    //    public string QryGroup37 { get; set; }
    //    public string QryGroup38 { get; set; }
    //    public string QryGroup39 { get; set; }
    //    public string QryGroup40 { get; set; }
    //    public string QryGroup41 { get; set; }
    //    public string QryGroup42 { get; set; }
    //    public string QryGroup43 { get; set; }
    //    public string QryGroup44 { get; set; }
    //    public string QryGroup45 { get; set; }
    //    public string QryGroup46 { get; set; }
    //    public string QryGroup47 { get; set; }
    //    public string QryGroup48 { get; set; }
    //    public string QryGroup49 { get; set; }
    //    public string QryGroup50 { get; set; }
    //    public string QryGroup51 { get; set; }
    //    public string QryGroup52 { get; set; }
    //    public string QryGroup53 { get; set; }
    //    public string QryGroup54 { get; set; }
    //    public string QryGroup55 { get; set; }
    //    public string QryGroup56 { get; set; }
    //    public string QryGroup57 { get; set; }
    //    public string QryGroup58 { get; set; }
    //    public string QryGroup59 { get; set; }
    //    public string QryGroup60 { get; set; }
    //    public string QryGroup61 { get; set; }
    //    public string QryGroup62 { get; set; }
    //    public string QryGroup63 { get; set; }
    //    public string QryGroup64 { get; set; }
    //    public Nullable<System.DateTime> CreateDate { get; set; }
    //    public Nullable<System.DateTime> UpdateDate { get; set; }
    //    public string ExportCode { get; set; }
    //    public Nullable<decimal> SalFactor1 { get; set; }
    //    public Nullable<decimal> SalFactor2 { get; set; }
    //    public Nullable<decimal> SalFactor3 { get; set; }
    //    public Nullable<decimal> SalFactor4 { get; set; }
    //    public Nullable<decimal> PurFactor1 { get; set; }
    //    public Nullable<decimal> PurFactor2 { get; set; }
    //    public Nullable<decimal> PurFactor3 { get; set; }
    //    public Nullable<decimal> PurFactor4 { get; set; }
    //    public string SalFormula { get; set; }
    //    public string PurFormula { get; set; }
    //    public string VatGroupPu { get; set; }
    //    public Nullable<decimal> AvgPrice { get; set; }
    //    public string PurPackMsr { get; set; }
    //    public Nullable<decimal> PurPackUn { get; set; }
    //    public string SalPackMsr { get; set; }
    //    public Nullable<decimal> SalPackUn { get; set; }
    //    public Nullable<short> SCNCounter { get; set; }
    //    public string ManBtchNum { get; set; }
    //    public string ManOutOnly { get; set; }
    //    public string DataSource { get; set; }
    //    public string validFor { get; set; }
    //    public Nullable<System.DateTime> validFrom { get; set; }
    //    public Nullable<System.DateTime> validTo { get; set; }
    //    public string frozenFor { get; set; }
    //    public Nullable<System.DateTime> frozenFrom { get; set; }
    //    public Nullable<System.DateTime> frozenTo { get; set; }
    //    public string BlockOut { get; set; }
    //    public string ValidComm { get; set; }
    //    public string FrozenComm { get; set; }
    //    public Nullable<int> LogInstanc { get; set; }
    //    public string ObjType { get; set; }
    //    public string SWW { get; set; }
    //    public string Deleted { get; set; }
    //    public Nullable<int> DocEntry { get; set; }
    //    public string ExpensAcct { get; set; }
    //    public string FrgnInAcct { get; set; }
    //    public Nullable<short> ShipType { get; set; }
    //    public string GLMethod { get; set; }
    //    public string ECInAcct { get; set; }
    //    public string FrgnExpAcc { get; set; }
    //    public string ECExpAcc { get; set; }
    //    public string TaxType { get; set; }
    //    public string ByWh { get; set; }
    //    public string WTLiable { get; set; }
    //    public string ItemType { get; set; }
    //    public string WarrntTmpl { get; set; }
    //    public string BaseUnit { get; set; }
    //    public string CountryOrg { get; set; }
    //    public Nullable<decimal> StockValue { get; set; }
    //    public string Phantom { get; set; }
    //    public string IssueMthd { get; set; }
    //    public string FREE1 { get; set; }
    //    public Nullable<decimal> PricingPrc { get; set; }
    //    public string MngMethod { get; set; }
    //    public Nullable<decimal> ReorderPnt { get; set; }
    //    public string InvntryUom { get; set; }
    //    public string PlaningSys { get; set; }
    //    public string PrcrmntMtd { get; set; }
    //    public Nullable<short> OrdrIntrvl { get; set; }
    //    public Nullable<decimal> OrdrMulti { get; set; }
    //    public Nullable<decimal> MinOrdrQty { get; set; }
    //    public Nullable<int> LeadTime { get; set; }
    //    public string IndirctTax { get; set; }
    //    public string TaxCodeAR { get; set; }
    //    public string TaxCodeAP { get; set; }
    //    public Nullable<int> OSvcCode { get; set; }
    //    public Nullable<int> ISvcCode { get; set; }
    //    public Nullable<int> ServiceGrp { get; set; }
    //    public Nullable<int> NCMCode { get; set; }
    //    public string MatType { get; set; }
    //    public Nullable<int> MatGrp { get; set; }
    //    public string ProductSrc { get; set; }
    //    public Nullable<int> ServiceCtg { get; set; }
    //    public string ItemClass { get; set; }
    //    public string Excisable { get; set; }
    //    public Nullable<int> ChapterID { get; set; }
    //    public string NotifyASN { get; set; }
    //    public string ProAssNum { get; set; }
    //    public Nullable<decimal> AssblValue { get; set; }
    //    public Nullable<int> DNFEntry { get; set; }
    //    public Nullable<short> UserSign2 { get; set; }
    //    public string Spec { get; set; }
    //    public string TaxCtg { get; set; }
    //    public Nullable<short> Series { get; set; }
    //    public Nullable<int> Number { get; set; }
    //    public Nullable<int> FuelCode { get; set; }
    //    public string BeverTblC { get; set; }
    //    public string BeverGrpC { get; set; }
    //    public Nullable<int> BeverTM { get; set; }
    //    public string Attachment { get; set; }
    //    public Nullable<int> AtcEntry { get; set; }
    //    public Nullable<int> ToleranDay { get; set; }
    //    public Nullable<int> UgpEntry { get; set; }
    //    public Nullable<int> PUoMEntry { get; set; }
    //    public Nullable<int> SUoMEntry { get; set; }
    //    public Nullable<int> IUoMEntry { get; set; }
    //    public Nullable<short> IssuePriBy { get; set; }
    //    public string AssetClass { get; set; }
    //    public string AssetGroup { get; set; }
    //    public string InventryNo { get; set; }
    //    public Nullable<int> Technician { get; set; }
    //    public Nullable<int> Employee { get; set; }
    //    public Nullable<int> Location { get; set; }
    //    public string StatAsset { get; set; }
    //    public string Cession { get; set; }
    //    public string DeacAftUL { get; set; }
    //    public string AsstStatus { get; set; }
    //    public Nullable<System.DateTime> CapDate { get; set; }
    //    public Nullable<System.DateTime> AcqDate { get; set; }
    //    public Nullable<System.DateTime> RetDate { get; set; }
    //    public string GLPickMeth { get; set; }
    //    public string NoDiscount { get; set; }
    //    public string MgrByQty { get; set; }
    //    public string AssetRmk1 { get; set; }
    //    public string AssetRmk2 { get; set; }
    //    public Nullable<decimal> AssetAmnt1 { get; set; }
    //    public Nullable<decimal> AssetAmnt2 { get; set; }
    //    public string DeprGroup { get; set; }
    //    public string AssetSerNo { get; set; }
    //    public string CntUnitMsr { get; set; }
    //    public Nullable<decimal> NumInCnt { get; set; }
    //    public Nullable<int> INUoMEntry { get; set; }
    //    public string OneBOneRec { get; set; }
    //    public string RuleCode { get; set; }
    //    public string ScsCode { get; set; }
    //    public string SpProdType { get; set; }
    //    public Nullable<decimal> IWeight1 { get; set; }
    //    public Nullable<short> IWght1Unit { get; set; }
    //    public Nullable<decimal> IWeight2 { get; set; }
    //    public Nullable<short> IWght2Unit { get; set; }
    //    public string CompoWH { get; set; }
    //    public Nullable<int> CreateTS { get; set; }
    //    public Nullable<int> UpdateTS { get; set; }
    //    public string VirtAstItm { get; set; }
    //    public string SouVirAsst { get; set; }
    //    public string InCostRoll { get; set; }
    //    public Nullable<decimal> PrdStdCst { get; set; }
    //    public string EnAstSeri { get; set; }
    //    public string U_MaterialGroup { get; set; }
    //}

    public class OITM
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string FrgnName { get; set; }
        public short? ItmsGrpCod { get; set; }
        public short? CstGrpCode { get; set; }
        public string VatGourpSa { get; set; }
        public string CodeBars { get; set; }
        public string VATLiable { get; set; }
        public string PrchseItem { get; set; }
        public string SellItem { get; set; }
        public string InvntItem { get; set; }
        public decimal? OnHand { get; set; }
        public decimal? IsCommited { get; set; }
        public decimal? OnOrder { get; set; }

        //public decimal Price { get; set; }
        public string IncomeAcct { get; set; }
        public string ExmptIncom { get; set; }
        public decimal? MaxLevel { get; set; }
        public string DfltWH { get; set; }
        public string CardCode { get; set; }
        public string SuppCatNum { get; set; }
        public string BuyUnitMsr { get; set; }
        public decimal? NumInBuy { get; set; }
        public decimal? ReorderQty { get; set; }
        public decimal? MinLevel { get; set; }
        public decimal? LstEvlPric { get; set; }
        public DateTime? LstEvlDate { get; set; }
        public decimal? CustomPer { get; set; }
        public string Canceled { get; set; }
        public int? MnufctTime { get; set; }
        public string WholSlsTax { get; set; }
        public string RetilrTax { get; set; }
        public decimal? SpcialDisc { get; set; }
        public short? DscountCod { get; set; }
        public string TrackSales { get; set; }
        public string SalUnitMsr { get; set; }
        public decimal? NumInSale { get; set; }
        public decimal? Consig { get; set; }
        public int? QueryGroup { get; set; }
        public decimal? Counted { get; set; }
        public decimal? OpenBlnc { get; set; }
        public string EvalSystem { get; set; }
        public short? UserSign { get; set; }
        public string FREE { get; set; }
        public string PicturName { get; set; }
        public string Transfered { get; set; }
        public string BlncTrnsfr { get; set; }
        public string UserText { get; set; }
        public string SerialNum { get; set; }
        public decimal? CommisPcnt { get; set; }
        public decimal? CommisSum { get; set; }
        public short? CommisGrp { get; set; }
        public string TreeType { get; set; }
        public decimal? TreeQty { get; set; }
        public decimal? LastPurPrc { get; set; }
        public string LastPurCur { get; set; }
        public DateTime? LastPurDat { get; set; }
        public string ExitCur { get; set; }
        public decimal? ExitPrice { get; set; }
        public string ExitWH { get; set; }
        public string AssetItem { get; set; }
        public string WasCounted { get; set; }
        public string ManSerNum { get; set; }
        public decimal? SHeight1 { get; set; }
        public short? SHght1Unit { get; set; }
        public decimal? SHeight2 { get; set; }
        public short? SHght2Unit { get; set; }
        public decimal? SWidth1 { get; set; }
        public short? SWdth1Unit { get; set; }
        public decimal? SWidth2 { get; set; }
        public short? SWdth2Unit { get; set; }
        public decimal? SLength1 { get; set; }
        public short? SLen1Unit { get; set; }
        public decimal? Slength2 { get; set; }
        public short? SLen2Unit { get; set; }
        public decimal? SVolume { get; set; }
        public short? SVolUnit { get; set; }
        public decimal? SWeight1 { get; set; }
        public short? SWght1Unit { get; set; }
        public decimal? SWeight2 { get; set; }
        public short? SWght2Unit { get; set; }
        public decimal? BHeight1 { get; set; }
        public short? BHght1Unit { get; set; }
        public decimal? BHeight2 { get; set; }
        public short? BHght2Unit { get; set; }
        public decimal? BWidth1 { get; set; }
        public short? BWdth1Unit { get; set; }
        public decimal? BWidth2 { get; set; }
        public short? BWdth2Unit { get; set; }
        public decimal? BLength1 { get; set; }
        public short? BLen1Unit { get; set; }
        public decimal? Blength2 { get; set; }
        public short? BLen2Unit { get; set; }
        public decimal? BVolume { get; set; }
        public short? BVolUnit { get; set; }
        public decimal? BWeight1 { get; set; }
        public short? BWght1Unit { get; set; }
        public decimal? BWeight2 { get; set; }
        public short? BWght2Unit { get; set; }
        public string FixCurrCms { get; set; }
        public short? FirmCode { get; set; }
        public DateTime? LstSalDate { get; set; }
        public string QryGroup1 { get; set; }
        public string QryGroup2 { get; set; }
        public string QryGroup3 { get; set; }
        public string QryGroup4 { get; set; }
        public string QryGroup5 { get; set; }
        public string QryGroup6 { get; set; }
        public string QryGroup7 { get; set; }
        public string QryGroup8 { get; set; }
        public string QryGroup9 { get; set; }
        public string QryGroup10 { get; set; }
        public string QryGroup11 { get; set; }
        public string QryGroup12 { get; set; }
        public string QryGroup13 { get; set; }
        public string QryGroup14 { get; set; }
        public string QryGroup15 { get; set; }
        public string QryGroup16 { get; set; }
        public string QryGroup17 { get; set; }
        public string QryGroup18 { get; set; }
        public string QryGroup19 { get; set; }
        public string QryGroup20 { get; set; }
        public string QryGroup21 { get; set; }
        public string QryGroup22 { get; set; }
        public string QryGroup23 { get; set; }
        public string QryGroup24 { get; set; }
        public string QryGroup25 { get; set; }
        public string QryGroup26 { get; set; }
        public string QryGroup27 { get; set; }
        public string QryGroup28 { get; set; }
        public string QryGroup29 { get; set; }
        public string QryGroup30 { get; set; }
        public string QryGroup31 { get; set; }
        public string QryGroup32 { get; set; }
        public string QryGroup33 { get; set; }
        public string QryGroup34 { get; set; }
        public string QryGroup35 { get; set; }
        public string QryGroup36 { get; set; }
        public string QryGroup37 { get; set; }
        public string QryGroup38 { get; set; }
        public string QryGroup39 { get; set; }
        public string QryGroup40 { get; set; }
        public string QryGroup41 { get; set; }
        public string QryGroup42 { get; set; }
        public string QryGroup43 { get; set; }
        public string QryGroup44 { get; set; }
        public string QryGroup45 { get; set; }
        public string QryGroup46 { get; set; }
        public string QryGroup47 { get; set; }
        public string QryGroup48 { get; set; }
        public string QryGroup49 { get; set; }
        public string QryGroup50 { get; set; }
        public string QryGroup51 { get; set; }
        public string QryGroup52 { get; set; }
        public string QryGroup53 { get; set; }
        public string QryGroup54 { get; set; }
        public string QryGroup55 { get; set; }
        public string QryGroup56 { get; set; }
        public string QryGroup57 { get; set; }
        public string QryGroup58 { get; set; }
        public string QryGroup59 { get; set; }
        public string QryGroup60 { get; set; }
        public string QryGroup61 { get; set; }
        public string QryGroup62 { get; set; }
        public string QryGroup63 { get; set; }
        public string QryGroup64 { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ExportCode { get; set; }
        public decimal? SalFactor1 { get; set; }
        public decimal? SalFactor2 { get; set; }
        public decimal? SalFactor3 { get; set; }
        public decimal? SalFactor4 { get; set; }
        public decimal? PurFactor1 { get; set; }
        public decimal? PurFactor2 { get; set; }
        public decimal? PurFactor3 { get; set; }
        public decimal? PurFactor4 { get; set; }
        public string SalFormula { get; set; }
        public string PurFormula { get; set; }
        public string VatGroupPu { get; set; }
        public decimal? AvgPrice { get; set; }
        public string PurPackMsr { get; set; }
        public decimal? PurPackUn { get; set; }
        public string SalPackMsr { get; set; }
        public decimal? SalPackUn { get; set; }
        public short? SCNCounter { get; set; }
        public string ManBtchNum { get; set; }
        public string ManOutOnly { get; set; }
        public string DataSource { get; set; }
        public string validFor { get; set; }
        public DateTime? validFrom { get; set; }
        public DateTime? validTo { get; set; }
        public string frozenFor { get; set; }
        public DateTime? frozenFrom { get; set; }
        public DateTime? frozenTo { get; set; }
        public string BlockOut { get; set; }
        public string ValidComm { get; set; }
        public string FrozenComm { get; set; }
        public int? LogInstanc { get; set; }
        public string ObjType { get; set; }
        public string SWW { get; set; }
        public string Deleted { get; set; }
        public int? DocEntry { get; set; }
        public string ExpensAcct { get; set; }
        public string FrgnInAcct { get; set; }
        public short? ShipType { get; set; }
        public string GLMethod { get; set; }
        public string ECInAcct { get; set; }
        public string FrgnExpAcc { get; set; }
        public string ECExpAcc { get; set; }
        public string TaxType { get; set; }
        public string ByWh { get; set; }
        public string WTLiable { get; set; }
        public string ItemType { get; set; }
        public string WarrntTmpl { get; set; }
        public string BaseUnit { get; set; }
        public string CountryOrg { get; set; }
        public decimal? StockValue { get; set; }
        public string Phantom { get; set; }
        public string IssueMthd { get; set; }
        public string FREE1 { get; set; }
        public decimal? PricingPrc { get; set; }
        public string MngMethod { get; set; }
        public decimal? ReorderPnt { get; set; }
        public string InvntryUom { get; set; }
        public string PlaningSys { get; set; }
        public string PrcrmntMtd { get; set; }
        public short? OrdrIntrvl { get; set; }
        public decimal? OrdrMulti { get; set; }
        public decimal? MinOrdrQty { get; set; }
        public int? LeadTime { get; set; }
        public string IndirctTax { get; set; }
        public string TaxCodeAR { get; set; }
        public string TaxCodeAP { get; set; }
        public int? OSvcCode { get; set; }
        public int? ISvcCode { get; set; }
        public int? ServiceGrp { get; set; }
        public int? NCMCode { get; set; }
        public string MatType { get; set; }
        public int? MatGrp { get; set; }
        public string ProductSrc { get; set; }
        public int? ServiceCtg { get; set; }
        public string ItemClass { get; set; }
        public string Excisable { get; set; }
        public int? ChapterID { get; set; }
        public string NotifyASN { get; set; }
        public string ProAssNum { get; set; }
        public decimal? AssblValue { get; set; }
        public int? DNFEntry { get; set; }
        public short? UserSign2 { get; set; }
        public string Spec { get; set; }
        public string TaxCtg { get; set; }
        public short? Series { get; set; }
        public int? Number { get; set; }
        public int? FuelCode { get; set; }
        public string BeverTblC { get; set; }
        public string BeverGrpC { get; set; }
        public int? BeverTM { get; set; }
        public string Attachment { get; set; }
        public int? AtcEntry { get; set; }
        public int? ToleranDay { get; set; }
        public int? UgpEntry { get; set; }
        public int? PUoMEntry { get; set; }
        public int? SUoMEntry { get; set; }
        public int? IUoMEntry { get; set; }
        public short? IssuePriBy { get; set; }
        public string AssetClass { get; set; }
        public string AssetGroup { get; set; }
        public string InventryNo { get; set; }
        public int? Technician { get; set; }
        public int? Employee { get; set; }
        public int? Location { get; set; }
        public string StatAsset { get; set; }
        public string Cession { get; set; }
        public string DeacAftUL { get; set; }
        public string AsstStatus { get; set; }
        public DateTime? CapDate { get; set; }
        public DateTime? AcqDate { get; set; }
        public DateTime? RetDate { get; set; }
        public string GLPickMeth { get; set; }
        public string NoDiscount { get; set; }
        public string MgrByQty { get; set; }
        public string AssetRmk1 { get; set; }
        public string AssetRmk2 { get; set; }
        public decimal? AssetAmnt1 { get; set; }
        public decimal? AssetAmnt2 { get; set; }
        public string DeprGroup { get; set; }
        public string AssetSerNo { get; set; }
        public string CntUnitMsr { get; set; }
        public decimal? NumInCnt { get; set; }
        public int? INUoMEntry { get; set; }
        public string OneBOneRec { get; set; }
        public string RuleCode { get; set; }
        public string ScsCode { get; set; }
        public string SpProdType { get; set; }
        public decimal? IWeight1 { get; set; }
        public short? IWght1Unit { get; set; }
        public decimal? IWeight2 { get; set; }
        public short? IWght2Unit { get; set; }
        public string CompoWH { get; set; }
        public int? CreateTS { get; set; }
        public int? UpdateTS { get; set; }
        public string VirtAstItm { get; set; }
        public string SouVirAsst { get; set; }
        public string InCostRoll { get; set; }
        public decimal? PrdStdCst { get; set; }
        public string EnAstSeri { get; set; }
        public string U_SubGroup { get; set; }
    }
}
