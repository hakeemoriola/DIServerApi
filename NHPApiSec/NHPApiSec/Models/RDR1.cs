using System;
using System.Collections.Generic;

namespace NHPApi.Models
{
    //public partial class RDR1
    //{
    //    public int DocEntry { get; set; }
    //    public int LineNum { get; set; }
    //    public Nullable<int> TargetType { get; set; }
    //    public Nullable<int> TrgetEntry { get; set; }
    //    public string BaseRef { get; set; }
    //    public Nullable<int> BaseType { get; set; }
    //    public Nullable<int> BaseEntry { get; set; }
    //    public Nullable<int> BaseLine { get; set; }
    //    public string LineStatus { get; set; }
    //    public string ItemCode { get; set; }
    //    public string Dscription { get; set; }
    //    public Nullable<decimal> Quantity { get; set; }
    //    public Nullable<System.DateTime> ShipDate { get; set; }
    //    public Nullable<decimal> OpenQty { get; set; }
    //    public Nullable<decimal> Price { get; set; }
    //    public string Currency { get; set; }
    //    public Nullable<decimal> Rate { get; set; }
    //    public Nullable<decimal> DiscPrcnt { get; set; }
    //    public Nullable<decimal> LineTotal { get; set; }
    //    public Nullable<decimal> TotalFrgn { get; set; }
    //    public Nullable<decimal> OpenSum { get; set; }
    //    public Nullable<decimal> OpenSumFC { get; set; }
    //    public string VendorNum { get; set; }
    //    public string SerialNum { get; set; }
    //    public string WhsCode { get; set; }
    //    public Nullable<int> SlpCode { get; set; }
    //    public Nullable<decimal> Commission { get; set; }
    //    public string TreeType { get; set; }
    //    public string AcctCode { get; set; }
    //    public string TaxStatus { get; set; }
    //    public Nullable<decimal> GrossBuyPr { get; set; }
    //    public Nullable<decimal> PriceBefDi { get; set; }
    //    public Nullable<System.DateTime> DocDate { get; set; }
    //    public Nullable<int> Flags { get; set; }
    //    public Nullable<decimal> OpenCreQty { get; set; }
    //    public string UseBaseUn { get; set; }
    //    public string SubCatNum { get; set; }
    //    public string BaseCard { get; set; }
    //    public Nullable<decimal> TotalSumSy { get; set; }
    //    public Nullable<decimal> OpenSumSys { get; set; }
    //    public string InvntSttus { get; set; }
    //    public string OcrCode { get; set; }
    //    public string Project { get; set; }
    //    public string CodeBars { get; set; }
    //    public Nullable<decimal> VatPrcnt { get; set; }
    //    public string VatGroup { get; set; }
    //    public Nullable<decimal> PriceAfVAT { get; set; }
    //    public Nullable<decimal> Height1 { get; set; }
    //    public Nullable<short> Hght1Unit { get; set; }
    //    public Nullable<decimal> Height2 { get; set; }
    //    public Nullable<short> Hght2Unit { get; set; }
    //    public Nullable<decimal> Width1 { get; set; }
    //    public Nullable<short> Wdth1Unit { get; set; }
    //    public Nullable<decimal> Width2 { get; set; }
    //    public Nullable<short> Wdth2Unit { get; set; }
    //    public Nullable<decimal> Length1 { get; set; }
    //    public Nullable<short> Len1Unit { get; set; }
    //    public Nullable<decimal> length2 { get; set; }
    //    public Nullable<short> Len2Unit { get; set; }
    //    public Nullable<decimal> Volume { get; set; }
    //    public Nullable<short> VolUnit { get; set; }
    //    public Nullable<decimal> Weight1 { get; set; }
    //    public Nullable<short> Wght1Unit { get; set; }
    //    public Nullable<decimal> Weight2 { get; set; }
    //    public Nullable<short> Wght2Unit { get; set; }
    //    public Nullable<decimal> Factor1 { get; set; }
    //    public Nullable<decimal> Factor2 { get; set; }
    //    public Nullable<decimal> Factor3 { get; set; }
    //    public Nullable<decimal> Factor4 { get; set; }
    //    public Nullable<decimal> PackQty { get; set; }
    //    public string UpdInvntry { get; set; }
    //    public Nullable<int> BaseDocNum { get; set; }
    //    public string BaseAtCard { get; set; }
    //    public string SWW { get; set; }
    //    public Nullable<decimal> VatSum { get; set; }
    //    public Nullable<decimal> VatSumFrgn { get; set; }
    //    public Nullable<decimal> VatSumSy { get; set; }
    //    public Nullable<int> FinncPriod { get; set; }
    //    public string ObjType { get; set; }
    //    public Nullable<int> LogInstanc { get; set; }
    //    public string BlockNum { get; set; }
    //    public string ImportLog { get; set; }
    //    public Nullable<decimal> DedVatSum { get; set; }
    //    public Nullable<decimal> DedVatSumF { get; set; }
    //    public Nullable<decimal> DedVatSumS { get; set; }
    //    public string IsAqcuistn { get; set; }
    //    public Nullable<decimal> DistribSum { get; set; }
    //    public Nullable<decimal> DstrbSumFC { get; set; }
    //    public Nullable<decimal> DstrbSumSC { get; set; }
    //    public Nullable<decimal> GrssProfit { get; set; }
    //    public Nullable<decimal> GrssProfSC { get; set; }
    //    public Nullable<decimal> GrssProfFC { get; set; }
    //    public Nullable<int> VisOrder { get; set; }
    //    public Nullable<decimal> INMPrice { get; set; }
    //    public Nullable<int> PoTrgNum { get; set; }
    //    public string PoTrgEntry { get; set; }
    //    public string DropShip { get; set; }
    //    public Nullable<int> PoLineNum { get; set; }
    //    public string Address { get; set; }
    //    public string TaxCode { get; set; }
    //    public string TaxType { get; set; }
    //    public string OrigItem { get; set; }
    //    public string BackOrdr { get; set; }
    //    public string FreeTxt { get; set; }
    //    public string PickStatus { get; set; }
    //    public Nullable<decimal> PickOty { get; set; }
    //    public Nullable<int> PickIdNo { get; set; }
    //    public Nullable<short> TrnsCode { get; set; }
    //    public Nullable<decimal> VatAppld { get; set; }
    //    public Nullable<decimal> VatAppldFC { get; set; }
    //    public Nullable<decimal> VatAppldSC { get; set; }
    //    public Nullable<decimal> BaseQty { get; set; }
    //    public Nullable<decimal> BaseOpnQty { get; set; }
    //    public Nullable<decimal> VatDscntPr { get; set; }
    //    public string WtLiable { get; set; }
    //    public string DeferrTax { get; set; }
    //    public Nullable<decimal> EquVatPer { get; set; }
    //    public Nullable<decimal> EquVatSum { get; set; }
    //    public Nullable<decimal> EquVatSumF { get; set; }
    //    public Nullable<decimal> EquVatSumS { get; set; }
    //    public Nullable<decimal> LineVat { get; set; }
    //    public Nullable<decimal> LineVatlF { get; set; }
    //    public Nullable<decimal> LineVatS { get; set; }
    //    public string unitMsr { get; set; }
    //    public Nullable<decimal> NumPerMsr { get; set; }
    //    public string CEECFlag { get; set; }
    //    public Nullable<decimal> ToStock { get; set; }
    //    public Nullable<decimal> ToDiff { get; set; }
    //    public Nullable<decimal> ExciseAmt { get; set; }
    //    public Nullable<decimal> TaxPerUnit { get; set; }
    //    public Nullable<decimal> TotInclTax { get; set; }
    //    public string CountryOrg { get; set; }
    //    public Nullable<decimal> StckDstSum { get; set; }
    //    public Nullable<decimal> ReleasQtty { get; set; }
    //    public string LineType { get; set; }
    //    public string TranType { get; set; }
    //    public string Text { get; set; }
    //    public Nullable<int> OwnerCode { get; set; }
    //    public Nullable<decimal> StockPrice { get; set; }
    //    public string ConsumeFCT { get; set; }
    //    public Nullable<decimal> LstByDsSum { get; set; }
    //    public Nullable<decimal> StckINMPr { get; set; }
    //    public Nullable<decimal> LstBINMPr { get; set; }
    //    public Nullable<decimal> StckDstFc { get; set; }
    //    public Nullable<decimal> StckDstSc { get; set; }
    //    public Nullable<decimal> LstByDsFc { get; set; }
    //    public Nullable<decimal> LstByDsSc { get; set; }
    //    public Nullable<decimal> StockSum { get; set; }
    //    public Nullable<decimal> StockSumFc { get; set; }
    //    public Nullable<decimal> StockSumSc { get; set; }
    //    public Nullable<decimal> StckSumApp { get; set; }
    //    public Nullable<decimal> StckAppFc { get; set; }
    //    public Nullable<decimal> StckAppSc { get; set; }
    //    public string ShipToCode { get; set; }
    //    public string ShipToDesc { get; set; }
    //    public Nullable<decimal> StckAppD { get; set; }
    //    public Nullable<decimal> StckAppDFC { get; set; }
    //    public Nullable<decimal> StckAppDSC { get; set; }
    //    public string BasePrice { get; set; }
    //    public Nullable<decimal> GTotal { get; set; }
    //    public Nullable<decimal> GTotalFC { get; set; }
    //    public Nullable<decimal> GTotalSC { get; set; }
    //    public string DistribExp { get; set; }
    //    public string DescOW { get; set; }
    //    public string DetailsOW { get; set; }
    //    public Nullable<short> GrossBase { get; set; }
    //    public Nullable<decimal> VatWoDpm { get; set; }
    //    public Nullable<decimal> VatWoDpmFc { get; set; }
    //    public Nullable<decimal> VatWoDpmSc { get; set; }
    //    public string CFOPCode { get; set; }
    //    public string CSTCode { get; set; }
    //    public Nullable<int> Usage { get; set; }
    //    public string TaxOnly { get; set; }
    //    public string WtCalced { get; set; }
    //    public Nullable<decimal> QtyToShip { get; set; }
    //    public Nullable<decimal> DelivrdQty { get; set; }
    //    public Nullable<decimal> OrderedQty { get; set; }
    //    public string CogsOcrCod { get; set; }
    //    public Nullable<int> CiOppLineN { get; set; }
    //    public string CogsAcct { get; set; }
    //    public string ChgAsmBoMW { get; set; }
    //    public Nullable<System.DateTime> ActDelDate { get; set; }
    //    public string OcrCode2 { get; set; }
    //    public string OcrCode3 { get; set; }
    //    public string OcrCode4 { get; set; }
    //    public string OcrCode5 { get; set; }
    //    public Nullable<decimal> TaxDistSum { get; set; }
    //    public Nullable<decimal> TaxDistSFC { get; set; }
    //    public Nullable<decimal> TaxDistSSC { get; set; }
    //    public string PostTax { get; set; }
    //    public string Excisable { get; set; }
    //    public Nullable<decimal> AssblValue { get; set; }
    //    public Nullable<int> RG23APart1 { get; set; }
    //    public Nullable<int> RG23APart2 { get; set; }
    //    public Nullable<int> RG23CPart1 { get; set; }
    //    public Nullable<int> RG23CPart2 { get; set; }
    //    public string CogsOcrCo2 { get; set; }
    //    public string CogsOcrCo3 { get; set; }
    //    public string CogsOcrCo4 { get; set; }
    //    public string CogsOcrCo5 { get; set; }
    //    public string LnExcised { get; set; }
    //    public Nullable<int> LocCode { get; set; }
    //    public Nullable<decimal> StockValue { get; set; }
    //    public Nullable<decimal> GPTtlBasPr { get; set; }
    //    public string unitMsr2 { get; set; }
    //    public Nullable<decimal> NumPerMsr2 { get; set; }
    //    public string SpecPrice { get; set; }
    //    public string CSTfIPI { get; set; }
    //    public string CSTfPIS { get; set; }
    //    public string CSTfCOFINS { get; set; }
    //    public string ExLineNo { get; set; }
    //    public string isSrvCall { get; set; }
    //    public Nullable<decimal> PQTReqQty { get; set; }
    //    public Nullable<System.DateTime> PQTReqDate { get; set; }
    //    public Nullable<int> PcDocType { get; set; }
    //    public Nullable<decimal> PcQuantity { get; set; }
    //    public string LinManClsd { get; set; }
    //    public string VatGrpSrc { get; set; }
    //    public string NoInvtryMv { get; set; }
    //    public Nullable<int> ActBaseEnt { get; set; }
    //    public Nullable<int> ActBaseLn { get; set; }
    //    public Nullable<int> ActBaseNum { get; set; }
    //    public Nullable<decimal> OpenRtnQty { get; set; }
    //    public Nullable<int> AgrNo { get; set; }
    //    public Nullable<int> AgrLnNum { get; set; }
    //    public string CredOrigin { get; set; }
    //    public Nullable<decimal> Surpluses { get; set; }
    //    public Nullable<decimal> DefBreak { get; set; }
    //    public Nullable<decimal> Shortages { get; set; }
    //    public Nullable<int> UomEntry { get; set; }
    //    public Nullable<int> UomEntry2 { get; set; }
    //    public string UomCode { get; set; }
    //    public string UomCode2 { get; set; }
    //    public string FromWhsCod { get; set; }
    //    public string NeedQty { get; set; }
    //    public string PartRetire { get; set; }
    //    public Nullable<decimal> RetireQty { get; set; }
    //    public Nullable<decimal> RetireAPC { get; set; }
    //    public Nullable<decimal> RetirAPCFC { get; set; }
    //    public Nullable<decimal> RetirAPCSC { get; set; }
    //    public Nullable<decimal> InvQty { get; set; }
    //    public Nullable<decimal> OpenInvQty { get; set; }
    //    public string EnSetCost { get; set; }
    //    public Nullable<decimal> RetCost { get; set; }
    //    public Nullable<int> Incoterms { get; set; }
    //    public Nullable<int> TransMod { get; set; }
    //    public string LineVendor { get; set; }
    //    public string DistribIS { get; set; }
    //    public Nullable<decimal> ISDistrb { get; set; }
    //    public Nullable<decimal> ISDistrbFC { get; set; }
    //    public Nullable<decimal> ISDistrbSC { get; set; }
    //    public string IsByPrdct { get; set; }
    //    public Nullable<int> ItemType { get; set; }
    //    public string PriceEdit { get; set; }
    //    public Nullable<int> PrntLnNum { get; set; }
    //    public string LinePoPrss { get; set; }
    //    public string FreeChrgBP { get; set; }
    //    public string TaxRelev { get; set; }
    //    public string LegalText { get; set; }
    //    public string ThirdParty { get; set; }
    //    public string LicTradNum { get; set; }
    //    public string InvQtyOnly { get; set; }
    //    public Nullable<int> UnencReasn { get; set; }
    //    public string ShipFromCo { get; set; }
    //    public string ShipFromDe { get; set; }
    //    public string FisrtBin { get; set; }
    //    public string AllocBinC { get; set; }
    //    public string ExpType { get; set; }
    //    public string ExpUUID { get; set; }
    //    public string ExpOpType { get; set; }
    //}

    public class RDR1
    {
        public int DocEntry { get; set; }
        public int LineNum { get; set; }
        public int? TargetType { get; set; }
        public int? TrgetEntry { get; set; }
        public string BaseRef { get; set; }
        public int? BaseType { get; set; }
        public int? BaseEntry { get; set; }
        public int? BaseLine { get; set; }
        public string LineStatus { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? ShipDate { get; set; }
        public decimal? OpenQty { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public decimal? Rate { get; set; }
        public decimal? DiscPrcnt { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? TotalFrgn { get; set; }
        public decimal? OpenSum { get; set; }
        public decimal? OpenSumFC { get; set; }
        public string VendorNum { get; set; }
        public string SerialNum { get; set; }
        public string WhsCode { get; set; }
        public int? SlpCode { get; set; }
        public decimal? Commission { get; set; }
        public string TreeType { get; set; }
        public string AcctCode { get; set; }
        public string TaxStatus { get; set; }
        public decimal? GrossBuyPr { get; set; }
        public decimal? PriceBefDi { get; set; }
        public DateTime? DocDate { get; set; }
        public int? Flags { get; set; }
        public decimal? OpenCreQty { get; set; }
        public string UseBaseUn { get; set; }
        public string SubCatNum { get; set; }
        public string BaseCard { get; set; }
        public decimal? TotalSumSy { get; set; }
        public decimal? OpenSumSys { get; set; }
        public string InvntSttus { get; set; }
        public string OcrCode { get; set; }
        public string Project { get; set; }
        public string CodeBars { get; set; }
        public decimal? VatPrcnt { get; set; }
        public string VatGroup { get; set; }
        public decimal? PriceAfVAT { get; set; }
        public decimal? Height1 { get; set; }
        public short? Hght1Unit { get; set; }
        public decimal? Height2 { get; set; }
        public short? Hght2Unit { get; set; }
        public decimal? Width1 { get; set; }
        public short? Wdth1Unit { get; set; }
        public decimal? Width2 { get; set; }
        public short? Wdth2Unit { get; set; }
        public decimal? Length1 { get; set; }
        public short? Len1Unit { get; set; }
        public decimal? length2 { get; set; }
        public short? Len2Unit { get; set; }
        public decimal? Volume { get; set; }
        public short? VolUnit { get; set; }
        public decimal? Weight1 { get; set; }
        public short? Wght1Unit { get; set; }
        public decimal? Weight2 { get; set; }
        public short? Wght2Unit { get; set; }
        public decimal? Factor1 { get; set; }
        public decimal? Factor2 { get; set; }
        public decimal? Factor3 { get; set; }
        public decimal? Factor4 { get; set; }
        public decimal? PackQty { get; set; }
        public string UpdInvntry { get; set; }
        public int? BaseDocNum { get; set; }
        public string BaseAtCard { get; set; }
        public string SWW { get; set; }
        public decimal? VatSum { get; set; }
        public decimal? VatSumFrgn { get; set; }
        public decimal? VatSumSy { get; set; }
        public int? FinncPriod { get; set; }
        public string ObjType { get; set; }
        public int? LogInstanc { get; set; }
        public string BlockNum { get; set; }
        public string ImportLog { get; set; }
        public decimal? DedVatSum { get; set; }
        public decimal? DedVatSumF { get; set; }
        public decimal? DedVatSumS { get; set; }
        public string IsAqcuistn { get; set; }
        public decimal? DistribSum { get; set; }
        public decimal? DstrbSumFC { get; set; }
        public decimal? DstrbSumSC { get; set; }
        public decimal? GrssProfit { get; set; }
        public decimal? GrssProfSC { get; set; }
        public decimal? GrssProfFC { get; set; }
        public int? VisOrder { get; set; }
        public decimal? INMPrice { get; set; }
        public int? PoTrgNum { get; set; }
        public string PoTrgEntry { get; set; }
        public string DropShip { get; set; }
        public int? PoLineNum { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string TaxType { get; set; }
        public string OrigItem { get; set; }
        public string BackOrdr { get; set; }
        public string FreeTxt { get; set; }
        public string PickStatus { get; set; }
        public decimal? PickOty { get; set; }
        public int? PickIdNo { get; set; }
        public short? TrnsCode { get; set; }
        public decimal? VatAppld { get; set; }
        public decimal? VatAppldFC { get; set; }
        public decimal? VatAppldSC { get; set; }
        public decimal? BaseQty { get; set; }
        public decimal? BaseOpnQty { get; set; }
        public decimal? VatDscntPr { get; set; }
        public string WtLiable { get; set; }
        public string DeferrTax { get; set; }
        public decimal? EquVatPer { get; set; }
        public decimal? EquVatSum { get; set; }
        public decimal? EquVatSumF { get; set; }
        public decimal? EquVatSumS { get; set; }
        public decimal? LineVat { get; set; }
        public decimal? LineVatlF { get; set; }
        public decimal? LineVatS { get; set; }
        public string unitMsr { get; set; }
        public decimal? NumPerMsr { get; set; }
        public string CEECFlag { get; set; }
        public decimal? ToStock { get; set; }
        public decimal? ToDiff { get; set; }
        public decimal? ExciseAmt { get; set; }
        public decimal? TaxPerUnit { get; set; }
        public decimal? TotInclTax { get; set; }
        public string CountryOrg { get; set; }
        public decimal? StckDstSum { get; set; }
        public decimal? ReleasQtty { get; set; }
        public string LineType { get; set; }
        public string TranType { get; set; }
        public string Text { get; set; }
        public int? OwnerCode { get; set; }
        public decimal? StockPrice { get; set; }
        public string ConsumeFCT { get; set; }
        public decimal? LstByDsSum { get; set; }
        public decimal? StckINMPr { get; set; }
        public decimal? LstBINMPr { get; set; }
        public decimal? StckDstFc { get; set; }
        public decimal? StckDstSc { get; set; }
        public decimal? LstByDsFc { get; set; }
        public decimal? LstByDsSc { get; set; }
        public decimal? StockSum { get; set; }
        public decimal? StockSumFc { get; set; }
        public decimal? StockSumSc { get; set; }
        public decimal? StckSumApp { get; set; }
        public decimal? StckAppFc { get; set; }
        public decimal? StckAppSc { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToDesc { get; set; }
        public decimal? StckAppD { get; set; }
        public decimal? StckAppDFC { get; set; }
        public decimal? StckAppDSC { get; set; }
        public string BasePrice { get; set; }
        public decimal? GTotal { get; set; }
        public decimal? GTotalFC { get; set; }
        public decimal? GTotalSC { get; set; }
        public string DistribExp { get; set; }
        public string DescOW { get; set; }
        public string DetailsOW { get; set; }
        public short? GrossBase { get; set; }
        public decimal? VatWoDpm { get; set; }
        public decimal? VatWoDpmFc { get; set; }
        public decimal? VatWoDpmSc { get; set; }
        public string CFOPCode { get; set; }
        public string CSTCode { get; set; }
        public int? Usage { get; set; }
        public string TaxOnly { get; set; }
        public string WtCalced { get; set; }
        public decimal? QtyToShip { get; set; }
        public decimal? DelivrdQty { get; set; }
        public decimal? OrderedQty { get; set; }
        public string CogsOcrCod { get; set; }
        public int? CiOppLineN { get; set; }
        public string CogsAcct { get; set; }
        public string ChgAsmBoMW { get; set; }
        public DateTime? ActDelDate { get; set; }
        public string OcrCode2 { get; set; }
        public string OcrCode3 { get; set; }
        public string OcrCode4 { get; set; }
        public string OcrCode5 { get; set; }
        public decimal? TaxDistSum { get; set; }
        public decimal? TaxDistSFC { get; set; }
        public decimal? TaxDistSSC { get; set; }
        public string PostTax { get; set; }
        public string Excisable { get; set; }
        public decimal? AssblValue { get; set; }
        public int? RG23APart1 { get; set; }
        public int? RG23APart2 { get; set; }
        public int? RG23CPart1 { get; set; }
        public int? RG23CPart2 { get; set; }
        public string CogsOcrCo2 { get; set; }
        public string CogsOcrCo3 { get; set; }
        public string CogsOcrCo4 { get; set; }
        public string CogsOcrCo5 { get; set; }
        public string LnExcised { get; set; }
        public int? LocCode { get; set; }
        public decimal? StockValue { get; set; }
        public decimal? GPTtlBasPr { get; set; }
        public string unitMsr2 { get; set; }
        public decimal? NumPerMsr2 { get; set; }
        public string SpecPrice { get; set; }
        public string CSTfIPI { get; set; }
        public string CSTfPIS { get; set; }
        public string CSTfCOFINS { get; set; }
        public string ExLineNo { get; set; }
        public string isSrvCall { get; set; }
        public decimal? PQTReqQty { get; set; }
        public DateTime? PQTReqDate { get; set; }
        public int? PcDocType { get; set; }
        public decimal? PcQuantity { get; set; }
        public string LinManClsd { get; set; }
        public string VatGrpSrc { get; set; }
        public string NoInvtryMv { get; set; }
        public int? ActBaseEnt { get; set; }
        public int? ActBaseLn { get; set; }
        public int? ActBaseNum { get; set; }
        public decimal? OpenRtnQty { get; set; }
        public int? AgrNo { get; set; }
        public int? AgrLnNum { get; set; }
        public string CredOrigin { get; set; }
        public decimal? Surpluses { get; set; }
        public decimal? DefBreak { get; set; }
        public decimal? Shortages { get; set; }
        public int? UomEntry { get; set; }
        public int? UomEntry2 { get; set; }
        public string UomCode { get; set; }
        public string UomCode2 { get; set; }
        public string FromWhsCod { get; set; }
        public string NeedQty { get; set; }
        public string PartRetire { get; set; }
        public decimal? RetireQty { get; set; }
        public decimal? RetireAPC { get; set; }
        public decimal? RetirAPCFC { get; set; }
        public decimal? RetirAPCSC { get; set; }
        public decimal? InvQty { get; set; }
        public decimal? OpenInvQty { get; set; }
        public string EnSetCost { get; set; }
        public decimal? RetCost { get; set; }
        public int? Incoterms { get; set; }
        public int? TransMod { get; set; }
        public string LineVendor { get; set; }
        public string DistribIS { get; set; }
        public decimal? ISDistrb { get; set; }
        public decimal? ISDistrbFC { get; set; }
        public decimal? ISDistrbSC { get; set; }
        public string IsByPrdct { get; set; }
        public int? ItemType { get; set; }
        public string PriceEdit { get; set; }
        public int? PrntLnNum { get; set; }
        public string LinePoPrss { get; set; }
        public string FreeChrgBP { get; set; }
        public string TaxRelev { get; set; }
        public string LegalText { get; set; }
        public string ThirdParty { get; set; }
        public string LicTradNum { get; set; }
        public string InvQtyOnly { get; set; }
        public int? UnencReasn { get; set; }
        public string ShipFromCo { get; set; }
        public string ShipFromDe { get; set; }
        public string FisrtBin { get; set; }
        public string AllocBinC { get; set; }
        public string ExpType { get; set; }
        public string ExpUUID { get; set; }
        public string ExpOpType { get; set; }
        public string U_UpdatePrice { get; set; }
        public decimal? U_NewPrice { get; set; }
    }
}
