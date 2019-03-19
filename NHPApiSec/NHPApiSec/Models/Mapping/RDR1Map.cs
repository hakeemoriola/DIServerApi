using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NHPApi.Models.Mapping
{
    public class RDR1Map : EntityTypeConfiguration<RDR1>
    {
        public RDR1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.DocEntry, t.LineNum });

            // Properties
            this.Property(t => t.DocEntry)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LineNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BaseRef)
                .HasMaxLength(16);

            this.Property(t => t.LineStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.Dscription)
                .HasMaxLength(100);

            this.Property(t => t.Currency)
                .HasMaxLength(3);

            this.Property(t => t.VendorNum)
                .HasMaxLength(50);

            this.Property(t => t.SerialNum)
                .HasMaxLength(17);

            this.Property(t => t.WhsCode)
                .HasMaxLength(8);

            this.Property(t => t.TreeType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AcctCode)
                .HasMaxLength(15);

            this.Property(t => t.TaxStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UseBaseUn)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SubCatNum)
                .HasMaxLength(50);

            this.Property(t => t.BaseCard)
                .HasMaxLength(15);

            this.Property(t => t.InvntSttus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OcrCode)
                .HasMaxLength(8);

            this.Property(t => t.Project)
                .HasMaxLength(20);

            this.Property(t => t.CodeBars)
                .HasMaxLength(254);

            this.Property(t => t.VatGroup)
                .HasMaxLength(8);

            this.Property(t => t.UpdInvntry)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BaseAtCard)
                .HasMaxLength(100);

            this.Property(t => t.SWW)
                .HasMaxLength(16);

            this.Property(t => t.ObjType)
                .HasMaxLength(20);

            this.Property(t => t.BlockNum)
                .HasMaxLength(100);

            this.Property(t => t.ImportLog)
                .HasMaxLength(20);

            this.Property(t => t.IsAqcuistn)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PoTrgEntry)
                .HasMaxLength(11);

            this.Property(t => t.DropShip)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Address)
                .HasMaxLength(254);

            this.Property(t => t.TaxCode)
                .HasMaxLength(8);

            this.Property(t => t.TaxType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OrigItem)
                .HasMaxLength(50);

            this.Property(t => t.BackOrdr)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FreeTxt)
                .HasMaxLength(100);

            this.Property(t => t.PickStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WtLiable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DeferrTax)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.unitMsr)
                .HasMaxLength(100);

            this.Property(t => t.CEECFlag)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CountryOrg)
                .HasMaxLength(3);

            this.Property(t => t.LineType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TranType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ConsumeFCT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ShipToCode)
                .HasMaxLength(50);

            this.Property(t => t.ShipToDesc)
                .HasMaxLength(254);

            this.Property(t => t.BasePrice)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DistribExp)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DescOW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DetailsOW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CFOPCode)
                .HasMaxLength(6);

            this.Property(t => t.CSTCode)
                .HasMaxLength(6);

            this.Property(t => t.TaxOnly)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WtCalced)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CogsOcrCod)
                .HasMaxLength(8);

            this.Property(t => t.CogsAcct)
                .HasMaxLength(15);

            this.Property(t => t.ChgAsmBoMW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OcrCode2)
                .HasMaxLength(8);

            this.Property(t => t.OcrCode3)
                .HasMaxLength(8);

            this.Property(t => t.OcrCode4)
                .HasMaxLength(8);

            this.Property(t => t.OcrCode5)
                .HasMaxLength(8);

            this.Property(t => t.PostTax)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Excisable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CogsOcrCo2)
                .HasMaxLength(8);

            this.Property(t => t.CogsOcrCo3)
                .HasMaxLength(8);

            this.Property(t => t.CogsOcrCo4)
                .HasMaxLength(8);

            this.Property(t => t.CogsOcrCo5)
                .HasMaxLength(8);

            this.Property(t => t.LnExcised)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.unitMsr2)
                .HasMaxLength(100);

            this.Property(t => t.SpecPrice)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CSTfIPI)
                .HasMaxLength(2);

            this.Property(t => t.CSTfPIS)
                .HasMaxLength(2);

            this.Property(t => t.CSTfCOFINS)
                .HasMaxLength(2);

            this.Property(t => t.ExLineNo)
                .HasMaxLength(10);

            this.Property(t => t.isSrvCall)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LinManClsd)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VatGrpSrc)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NoInvtryMv)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CredOrigin)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UomCode)
                .HasMaxLength(20);

            this.Property(t => t.UomCode2)
                .HasMaxLength(20);

            this.Property(t => t.FromWhsCod)
                .HasMaxLength(8);

            this.Property(t => t.NeedQty)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PartRetire)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EnSetCost)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LineVendor)
                .HasMaxLength(15);

            this.Property(t => t.DistribIS)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IsByPrdct)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PriceEdit)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LinePoPrss)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FreeChrgBP)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TaxRelev)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LegalText)
                .HasMaxLength(254);

            this.Property(t => t.ThirdParty)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LicTradNum)
                .HasMaxLength(32);

            this.Property(t => t.InvQtyOnly)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ShipFromCo)
                .HasMaxLength(50);

            this.Property(t => t.ShipFromDe)
                .HasMaxLength(254);

            this.Property(t => t.FisrtBin)
                .HasMaxLength(228);

            this.Property(t => t.AllocBinC)
                .HasMaxLength(11);

            this.Property(t => t.ExpType)
                .HasMaxLength(4);

            this.Property(t => t.ExpUUID)
                .HasMaxLength(50);

            this.Property(t => t.ExpOpType)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("RDR1");
            this.Property(t => t.DocEntry).HasColumnName("DocEntry");
            this.Property(t => t.LineNum).HasColumnName("LineNum");
            this.Property(t => t.TargetType).HasColumnName("TargetType");
            this.Property(t => t.TrgetEntry).HasColumnName("TrgetEntry");
            this.Property(t => t.BaseRef).HasColumnName("BaseRef");
            this.Property(t => t.BaseType).HasColumnName("BaseType");
            this.Property(t => t.BaseEntry).HasColumnName("BaseEntry");
            this.Property(t => t.BaseLine).HasColumnName("BaseLine");
            this.Property(t => t.LineStatus).HasColumnName("LineStatus");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.Dscription).HasColumnName("Dscription");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.ShipDate).HasColumnName("ShipDate");
            this.Property(t => t.OpenQty).HasColumnName("OpenQty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.DiscPrcnt).HasColumnName("DiscPrcnt");
            this.Property(t => t.LineTotal).HasColumnName("LineTotal");
            this.Property(t => t.TotalFrgn).HasColumnName("TotalFrgn");
            this.Property(t => t.OpenSum).HasColumnName("OpenSum");
            this.Property(t => t.OpenSumFC).HasColumnName("OpenSumFC");
            this.Property(t => t.VendorNum).HasColumnName("VendorNum");
            this.Property(t => t.SerialNum).HasColumnName("SerialNum");
            this.Property(t => t.WhsCode).HasColumnName("WhsCode");
            this.Property(t => t.SlpCode).HasColumnName("SlpCode");
            this.Property(t => t.Commission).HasColumnName("Commission");
            this.Property(t => t.TreeType).HasColumnName("TreeType");
            this.Property(t => t.AcctCode).HasColumnName("AcctCode");
            this.Property(t => t.TaxStatus).HasColumnName("TaxStatus");
            this.Property(t => t.GrossBuyPr).HasColumnName("GrossBuyPr");
            this.Property(t => t.PriceBefDi).HasColumnName("PriceBefDi");
            this.Property(t => t.DocDate).HasColumnName("DocDate");
            this.Property(t => t.Flags).HasColumnName("Flags");
            this.Property(t => t.OpenCreQty).HasColumnName("OpenCreQty");
            this.Property(t => t.UseBaseUn).HasColumnName("UseBaseUn");
            this.Property(t => t.SubCatNum).HasColumnName("SubCatNum");
            this.Property(t => t.BaseCard).HasColumnName("BaseCard");
            this.Property(t => t.TotalSumSy).HasColumnName("TotalSumSy");
            this.Property(t => t.OpenSumSys).HasColumnName("OpenSumSys");
            this.Property(t => t.InvntSttus).HasColumnName("InvntSttus");
            this.Property(t => t.OcrCode).HasColumnName("OcrCode");
            this.Property(t => t.Project).HasColumnName("Project");
            this.Property(t => t.CodeBars).HasColumnName("CodeBars");
            this.Property(t => t.VatPrcnt).HasColumnName("VatPrcnt");
            this.Property(t => t.VatGroup).HasColumnName("VatGroup");
            this.Property(t => t.PriceAfVAT).HasColumnName("PriceAfVAT");
            this.Property(t => t.Height1).HasColumnName("Height1");
            this.Property(t => t.Hght1Unit).HasColumnName("Hght1Unit");
            this.Property(t => t.Height2).HasColumnName("Height2");
            this.Property(t => t.Hght2Unit).HasColumnName("Hght2Unit");
            this.Property(t => t.Width1).HasColumnName("Width1");
            this.Property(t => t.Wdth1Unit).HasColumnName("Wdth1Unit");
            this.Property(t => t.Width2).HasColumnName("Width2");
            this.Property(t => t.Wdth2Unit).HasColumnName("Wdth2Unit");
            this.Property(t => t.Length1).HasColumnName("Length1");
            this.Property(t => t.Len1Unit).HasColumnName("Len1Unit");
            this.Property(t => t.length2).HasColumnName("length2");
            this.Property(t => t.Len2Unit).HasColumnName("Len2Unit");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.VolUnit).HasColumnName("VolUnit");
            this.Property(t => t.Weight1).HasColumnName("Weight1");
            this.Property(t => t.Wght1Unit).HasColumnName("Wght1Unit");
            this.Property(t => t.Weight2).HasColumnName("Weight2");
            this.Property(t => t.Wght2Unit).HasColumnName("Wght2Unit");
            this.Property(t => t.Factor1).HasColumnName("Factor1");
            this.Property(t => t.Factor2).HasColumnName("Factor2");
            this.Property(t => t.Factor3).HasColumnName("Factor3");
            this.Property(t => t.Factor4).HasColumnName("Factor4");
            this.Property(t => t.PackQty).HasColumnName("PackQty");
            this.Property(t => t.UpdInvntry).HasColumnName("UpdInvntry");
            this.Property(t => t.BaseDocNum).HasColumnName("BaseDocNum");
            this.Property(t => t.BaseAtCard).HasColumnName("BaseAtCard");
            this.Property(t => t.SWW).HasColumnName("SWW");
            this.Property(t => t.VatSum).HasColumnName("VatSum");
            this.Property(t => t.VatSumFrgn).HasColumnName("VatSumFrgn");
            this.Property(t => t.VatSumSy).HasColumnName("VatSumSy");
            this.Property(t => t.FinncPriod).HasColumnName("FinncPriod");
            this.Property(t => t.ObjType).HasColumnName("ObjType");
            this.Property(t => t.LogInstanc).HasColumnName("LogInstanc");
            this.Property(t => t.BlockNum).HasColumnName("BlockNum");
            this.Property(t => t.ImportLog).HasColumnName("ImportLog");
            this.Property(t => t.DedVatSum).HasColumnName("DedVatSum");
            this.Property(t => t.DedVatSumF).HasColumnName("DedVatSumF");
            this.Property(t => t.DedVatSumS).HasColumnName("DedVatSumS");
            this.Property(t => t.IsAqcuistn).HasColumnName("IsAqcuistn");
            this.Property(t => t.DistribSum).HasColumnName("DistribSum");
            this.Property(t => t.DstrbSumFC).HasColumnName("DstrbSumFC");
            this.Property(t => t.DstrbSumSC).HasColumnName("DstrbSumSC");
            this.Property(t => t.GrssProfit).HasColumnName("GrssProfit");
            this.Property(t => t.GrssProfSC).HasColumnName("GrssProfSC");
            this.Property(t => t.GrssProfFC).HasColumnName("GrssProfFC");
            this.Property(t => t.VisOrder).HasColumnName("VisOrder");
            this.Property(t => t.INMPrice).HasColumnName("INMPrice");
            this.Property(t => t.PoTrgNum).HasColumnName("PoTrgNum");
            this.Property(t => t.PoTrgEntry).HasColumnName("PoTrgEntry");
            this.Property(t => t.DropShip).HasColumnName("DropShip");
            this.Property(t => t.PoLineNum).HasColumnName("PoLineNum");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.TaxCode).HasColumnName("TaxCode");
            this.Property(t => t.TaxType).HasColumnName("TaxType");
            this.Property(t => t.OrigItem).HasColumnName("OrigItem");
            this.Property(t => t.BackOrdr).HasColumnName("BackOrdr");
            this.Property(t => t.FreeTxt).HasColumnName("FreeTxt");
            this.Property(t => t.PickStatus).HasColumnName("PickStatus");
            this.Property(t => t.PickOty).HasColumnName("PickOty");
            this.Property(t => t.PickIdNo).HasColumnName("PickIdNo");
            this.Property(t => t.TrnsCode).HasColumnName("TrnsCode");
            this.Property(t => t.VatAppld).HasColumnName("VatAppld");
            this.Property(t => t.VatAppldFC).HasColumnName("VatAppldFC");
            this.Property(t => t.VatAppldSC).HasColumnName("VatAppldSC");
            this.Property(t => t.BaseQty).HasColumnName("BaseQty");
            this.Property(t => t.BaseOpnQty).HasColumnName("BaseOpnQty");
            this.Property(t => t.VatDscntPr).HasColumnName("VatDscntPr");
            this.Property(t => t.WtLiable).HasColumnName("WtLiable");
            this.Property(t => t.DeferrTax).HasColumnName("DeferrTax");
            this.Property(t => t.EquVatPer).HasColumnName("EquVatPer");
            this.Property(t => t.EquVatSum).HasColumnName("EquVatSum");
            this.Property(t => t.EquVatSumF).HasColumnName("EquVatSumF");
            this.Property(t => t.EquVatSumS).HasColumnName("EquVatSumS");
            this.Property(t => t.LineVat).HasColumnName("LineVat");
            this.Property(t => t.LineVatlF).HasColumnName("LineVatlF");
            this.Property(t => t.LineVatS).HasColumnName("LineVatS");
            this.Property(t => t.unitMsr).HasColumnName("unitMsr");
            this.Property(t => t.NumPerMsr).HasColumnName("NumPerMsr");
            this.Property(t => t.CEECFlag).HasColumnName("CEECFlag");
            this.Property(t => t.ToStock).HasColumnName("ToStock");
            this.Property(t => t.ToDiff).HasColumnName("ToDiff");
            this.Property(t => t.ExciseAmt).HasColumnName("ExciseAmt");
            this.Property(t => t.TaxPerUnit).HasColumnName("TaxPerUnit");
            this.Property(t => t.TotInclTax).HasColumnName("TotInclTax");
            this.Property(t => t.CountryOrg).HasColumnName("CountryOrg");
            this.Property(t => t.StckDstSum).HasColumnName("StckDstSum");
            this.Property(t => t.ReleasQtty).HasColumnName("ReleasQtty");
            this.Property(t => t.LineType).HasColumnName("LineType");
            this.Property(t => t.TranType).HasColumnName("TranType");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.OwnerCode).HasColumnName("OwnerCode");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.ConsumeFCT).HasColumnName("ConsumeFCT");
            this.Property(t => t.LstByDsSum).HasColumnName("LstByDsSum");
            this.Property(t => t.StckINMPr).HasColumnName("StckINMPr");
            this.Property(t => t.LstBINMPr).HasColumnName("LstBINMPr");
            this.Property(t => t.StckDstFc).HasColumnName("StckDstFc");
            this.Property(t => t.StckDstSc).HasColumnName("StckDstSc");
            this.Property(t => t.LstByDsFc).HasColumnName("LstByDsFc");
            this.Property(t => t.LstByDsSc).HasColumnName("LstByDsSc");
            this.Property(t => t.StockSum).HasColumnName("StockSum");
            this.Property(t => t.StockSumFc).HasColumnName("StockSumFc");
            this.Property(t => t.StockSumSc).HasColumnName("StockSumSc");
            this.Property(t => t.StckSumApp).HasColumnName("StckSumApp");
            this.Property(t => t.StckAppFc).HasColumnName("StckAppFc");
            this.Property(t => t.StckAppSc).HasColumnName("StckAppSc");
            this.Property(t => t.ShipToCode).HasColumnName("ShipToCode");
            this.Property(t => t.ShipToDesc).HasColumnName("ShipToDesc");
            this.Property(t => t.StckAppD).HasColumnName("StckAppD");
            this.Property(t => t.StckAppDFC).HasColumnName("StckAppDFC");
            this.Property(t => t.StckAppDSC).HasColumnName("StckAppDSC");
            this.Property(t => t.BasePrice).HasColumnName("BasePrice");
            this.Property(t => t.GTotal).HasColumnName("GTotal");
            this.Property(t => t.GTotalFC).HasColumnName("GTotalFC");
            this.Property(t => t.GTotalSC).HasColumnName("GTotalSC");
            this.Property(t => t.DistribExp).HasColumnName("DistribExp");
            this.Property(t => t.DescOW).HasColumnName("DescOW");
            this.Property(t => t.DetailsOW).HasColumnName("DetailsOW");
            this.Property(t => t.GrossBase).HasColumnName("GrossBase");
            this.Property(t => t.VatWoDpm).HasColumnName("VatWoDpm");
            this.Property(t => t.VatWoDpmFc).HasColumnName("VatWoDpmFc");
            this.Property(t => t.VatWoDpmSc).HasColumnName("VatWoDpmSc");
            this.Property(t => t.CFOPCode).HasColumnName("CFOPCode");
            this.Property(t => t.CSTCode).HasColumnName("CSTCode");
            this.Property(t => t.Usage).HasColumnName("Usage");
            this.Property(t => t.TaxOnly).HasColumnName("TaxOnly");
            this.Property(t => t.WtCalced).HasColumnName("WtCalced");
            this.Property(t => t.QtyToShip).HasColumnName("QtyToShip");
            this.Property(t => t.DelivrdQty).HasColumnName("DelivrdQty");
            this.Property(t => t.OrderedQty).HasColumnName("OrderedQty");
            this.Property(t => t.CogsOcrCod).HasColumnName("CogsOcrCod");
            this.Property(t => t.CiOppLineN).HasColumnName("CiOppLineN");
            this.Property(t => t.CogsAcct).HasColumnName("CogsAcct");
            this.Property(t => t.ChgAsmBoMW).HasColumnName("ChgAsmBoMW");
            this.Property(t => t.ActDelDate).HasColumnName("ActDelDate");
            this.Property(t => t.OcrCode2).HasColumnName("OcrCode2");
            this.Property(t => t.OcrCode3).HasColumnName("OcrCode3");
            this.Property(t => t.OcrCode4).HasColumnName("OcrCode4");
            this.Property(t => t.OcrCode5).HasColumnName("OcrCode5");
            this.Property(t => t.TaxDistSum).HasColumnName("TaxDistSum");
            this.Property(t => t.TaxDistSFC).HasColumnName("TaxDistSFC");
            this.Property(t => t.TaxDistSSC).HasColumnName("TaxDistSSC");
            this.Property(t => t.PostTax).HasColumnName("PostTax");
            this.Property(t => t.Excisable).HasColumnName("Excisable");
            this.Property(t => t.AssblValue).HasColumnName("AssblValue");
            this.Property(t => t.RG23APart1).HasColumnName("RG23APart1");
            this.Property(t => t.RG23APart2).HasColumnName("RG23APart2");
            this.Property(t => t.RG23CPart1).HasColumnName("RG23CPart1");
            this.Property(t => t.RG23CPart2).HasColumnName("RG23CPart2");
            this.Property(t => t.CogsOcrCo2).HasColumnName("CogsOcrCo2");
            this.Property(t => t.CogsOcrCo3).HasColumnName("CogsOcrCo3");
            this.Property(t => t.CogsOcrCo4).HasColumnName("CogsOcrCo4");
            this.Property(t => t.CogsOcrCo5).HasColumnName("CogsOcrCo5");
            this.Property(t => t.LnExcised).HasColumnName("LnExcised");
            this.Property(t => t.LocCode).HasColumnName("LocCode");
            this.Property(t => t.StockValue).HasColumnName("StockValue");
            this.Property(t => t.GPTtlBasPr).HasColumnName("GPTtlBasPr");
            this.Property(t => t.unitMsr2).HasColumnName("unitMsr2");
            this.Property(t => t.NumPerMsr2).HasColumnName("NumPerMsr2");
            this.Property(t => t.SpecPrice).HasColumnName("SpecPrice");
            this.Property(t => t.CSTfIPI).HasColumnName("CSTfIPI");
            this.Property(t => t.CSTfPIS).HasColumnName("CSTfPIS");
            this.Property(t => t.CSTfCOFINS).HasColumnName("CSTfCOFINS");
            this.Property(t => t.ExLineNo).HasColumnName("ExLineNo");
            this.Property(t => t.isSrvCall).HasColumnName("isSrvCall");
            this.Property(t => t.PQTReqQty).HasColumnName("PQTReqQty");
            this.Property(t => t.PQTReqDate).HasColumnName("PQTReqDate");
            this.Property(t => t.PcDocType).HasColumnName("PcDocType");
            this.Property(t => t.PcQuantity).HasColumnName("PcQuantity");
            this.Property(t => t.LinManClsd).HasColumnName("LinManClsd");
            this.Property(t => t.VatGrpSrc).HasColumnName("VatGrpSrc");
            this.Property(t => t.NoInvtryMv).HasColumnName("NoInvtryMv");
            this.Property(t => t.ActBaseEnt).HasColumnName("ActBaseEnt");
            this.Property(t => t.ActBaseLn).HasColumnName("ActBaseLn");
            this.Property(t => t.ActBaseNum).HasColumnName("ActBaseNum");
            this.Property(t => t.OpenRtnQty).HasColumnName("OpenRtnQty");
            this.Property(t => t.AgrNo).HasColumnName("AgrNo");
            this.Property(t => t.AgrLnNum).HasColumnName("AgrLnNum");
            this.Property(t => t.CredOrigin).HasColumnName("CredOrigin");
            this.Property(t => t.Surpluses).HasColumnName("Surpluses");
            this.Property(t => t.DefBreak).HasColumnName("DefBreak");
            this.Property(t => t.Shortages).HasColumnName("Shortages");
            this.Property(t => t.UomEntry).HasColumnName("UomEntry");
            this.Property(t => t.UomEntry2).HasColumnName("UomEntry2");
            this.Property(t => t.UomCode).HasColumnName("UomCode");
            this.Property(t => t.UomCode2).HasColumnName("UomCode2");
            this.Property(t => t.FromWhsCod).HasColumnName("FromWhsCod");
            this.Property(t => t.NeedQty).HasColumnName("NeedQty");
            this.Property(t => t.PartRetire).HasColumnName("PartRetire");
            this.Property(t => t.RetireQty).HasColumnName("RetireQty");
            this.Property(t => t.RetireAPC).HasColumnName("RetireAPC");
            this.Property(t => t.RetirAPCFC).HasColumnName("RetirAPCFC");
            this.Property(t => t.RetirAPCSC).HasColumnName("RetirAPCSC");
            this.Property(t => t.InvQty).HasColumnName("InvQty");
            this.Property(t => t.OpenInvQty).HasColumnName("OpenInvQty");
            this.Property(t => t.EnSetCost).HasColumnName("EnSetCost");
            this.Property(t => t.RetCost).HasColumnName("RetCost");
            this.Property(t => t.Incoterms).HasColumnName("Incoterms");
            this.Property(t => t.TransMod).HasColumnName("TransMod");
            this.Property(t => t.LineVendor).HasColumnName("LineVendor");
            this.Property(t => t.DistribIS).HasColumnName("DistribIS");
            this.Property(t => t.ISDistrb).HasColumnName("ISDistrb");
            this.Property(t => t.ISDistrbFC).HasColumnName("ISDistrbFC");
            this.Property(t => t.ISDistrbSC).HasColumnName("ISDistrbSC");
            this.Property(t => t.IsByPrdct).HasColumnName("IsByPrdct");
            this.Property(t => t.ItemType).HasColumnName("ItemType");
            this.Property(t => t.PriceEdit).HasColumnName("PriceEdit");
            this.Property(t => t.PrntLnNum).HasColumnName("PrntLnNum");
            this.Property(t => t.LinePoPrss).HasColumnName("LinePoPrss");
            this.Property(t => t.FreeChrgBP).HasColumnName("FreeChrgBP");
            this.Property(t => t.TaxRelev).HasColumnName("TaxRelev");
            this.Property(t => t.LegalText).HasColumnName("LegalText");
            this.Property(t => t.ThirdParty).HasColumnName("ThirdParty");
            this.Property(t => t.LicTradNum).HasColumnName("LicTradNum");
            this.Property(t => t.InvQtyOnly).HasColumnName("InvQtyOnly");
            this.Property(t => t.UnencReasn).HasColumnName("UnencReasn");
            this.Property(t => t.ShipFromCo).HasColumnName("ShipFromCo");
            this.Property(t => t.ShipFromDe).HasColumnName("ShipFromDe");
            this.Property(t => t.FisrtBin).HasColumnName("FisrtBin");
            this.Property(t => t.AllocBinC).HasColumnName("AllocBinC");
            this.Property(t => t.ExpType).HasColumnName("ExpType");
            this.Property(t => t.ExpUUID).HasColumnName("ExpUUID");
            this.Property(t => t.ExpOpType).HasColumnName("ExpOpType");
        }
    }
}
