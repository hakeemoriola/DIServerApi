using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NHPApi.Models.Mapping
{
    public class ORDRMap : EntityTypeConfiguration<ORDR>
    {
        public ORDRMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DocEntry, t.DocNum, t.Instance, t.Segment, t.PIndicator, t.DocSubType });

            // Properties
            this.Property(t => t.DocEntry)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DocNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DocType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CANCELED)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Handwrtten)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Printed)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DocStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.InvntSttus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Transfered)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ObjType)
                .HasMaxLength(20);

            this.Property(t => t.CardCode)
                .HasMaxLength(15);

            this.Property(t => t.CardName)
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(254);

            this.Property(t => t.NumAtCard)
                .HasMaxLength(100);

            this.Property(t => t.DocCur)
                .HasMaxLength(3);

            this.Property(t => t.Ref1)
                .HasMaxLength(11);

            this.Property(t => t.Ref2)
                .HasMaxLength(11);

            this.Property(t => t.Comments)
                .HasMaxLength(254);

            this.Property(t => t.JrnlMemo)
                .HasMaxLength(50);

            this.Property(t => t.PartSupply)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Confirmed)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CreateTran)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SummryType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UpdInvnt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UpdCardBal)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Instance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvntDirec)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ShowSCN)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FatherCard)
                .HasMaxLength(15);

            this.Property(t => t.CurSource)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FatherType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IsICT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Filler)
                .HasMaxLength(8);

            this.Property(t => t.DataSource)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StampNum)
                .HasMaxLength(16);

            this.Property(t => t.isCrin)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.selfInv)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WddStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Address2)
                .HasMaxLength(254);

            this.Property(t => t.Exported)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Indicator)
                .HasMaxLength(2);

            this.Property(t => t.NetProc)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ShipToCode)
                .HasMaxLength(50);

            this.Property(t => t.LicTradNum)
                .HasMaxLength(32);

            this.Property(t => t.PaymentRef)
                .HasMaxLength(27);

            this.Property(t => t.CheckDigit)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Box1099)
                .HasMaxLength(20);

            this.Property(t => t.submitted)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PoPrss)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Rounding)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RevisionPo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Segment)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PickStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Pick)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BlockDunn)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PeyMethod)
                .HasMaxLength(15);

            this.Property(t => t.PayBlock)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MaxDscn)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Reserve)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CntrlBnk)
                .HasMaxLength(15);

            this.Property(t => t.PickRmrk)
                .HasMaxLength(254);

            this.Property(t => t.ISRCodLine)
                .HasMaxLength(53);

            this.Property(t => t.Project)
                .HasMaxLength(20);

            this.Property(t => t.DeferrTax)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LetterNum)
                .HasMaxLength(20);

            this.Property(t => t.BoeReserev)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AgentCode)
                .HasMaxLength(32);

            this.Property(t => t.VATFirst)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CorrExt)
                .HasMaxLength(25);

            this.Property(t => t.CEECFlag)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CtlAccount)
                .HasMaxLength(15);

            this.Property(t => t.BPLName)
                .HasMaxLength(100);

            this.Property(t => t.VATRegNum)
                .HasMaxLength(32);

            this.Property(t => t.TxInvRptNo)
                .HasMaxLength(10);

            this.Property(t => t.WTDetails)
                .HasMaxLength(100);

            this.Property(t => t.PIndicator)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ManualNum)
                .HasMaxLength(20);

            this.Property(t => t.UseShpdGd)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DocSubType)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DpmStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DpmDrawn)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FolioPref)
                .HasMaxLength(4);

            this.Property(t => t.Posted)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BPChCode)
                .HasMaxLength(15);

            this.Property(t => t.PayToCode)
                .HasMaxLength(50);

            this.Property(t => t.IsPaytoBnk)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BnkCntry)
                .HasMaxLength(3);

            this.Property(t => t.BankCode)
                .HasMaxLength(30);

            this.Property(t => t.BnkAccount)
                .HasMaxLength(50);

            this.Property(t => t.BnkBranch)
                .HasMaxLength(50);

            this.Property(t => t.isIns)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TrackNo)
                .HasMaxLength(30);

            this.Property(t => t.VersionNum)
                .HasMaxLength(11);

            this.Property(t => t.BPNameOW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BillToOW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ShipToOW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RetInvoice)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SeriesStr)
                .HasMaxLength(3);

            this.Property(t => t.SubStr)
                .HasMaxLength(3);

            this.Property(t => t.Model)
                .HasMaxLength(6);

            this.Property(t => t.LastPmnTyp)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UseCorrVat)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BlkCredMmo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OpenForLaC)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Excised)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ExcRmvTime)
                .HasMaxLength(8);

            this.Property(t => t.CertNum)
                .HasMaxLength(31);

            this.Property(t => t.DutyStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AutoCrtFlw)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FlwRefNum)
                .HasMaxLength(100);

            this.Property(t => t.InsurOp347)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IgnRelDoc)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BuildDesc)
                .HasMaxLength(50);

            this.Property(t => t.ResidenNum)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SSIExmpt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PQTGrpHW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ReopOriDoc)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ReopManCls)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DocManClsd)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Ordered)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NTSApprov)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NTSeTaxNo)
                .HasMaxLength(50);

            this.Property(t => t.NTSApprNo)
                .HasMaxLength(50);

            this.Property(t => t.PayDuMonth)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CertifNum)
                .HasMaxLength(50);

            this.Property(t => t.EDocGenTyp)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EDocNum)
                .HasMaxLength(50);

            this.Property(t => t.OnlineQuo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.POSEqNum)
                .HasMaxLength(20);

            this.Property(t => t.POSManufSN)
                .HasMaxLength(20);

            this.Property(t => t.EDocStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EDocProces)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EDocErrCod)
                .HasMaxLength(50);

            this.Property(t => t.EDocCancel)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EDocTest)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EDocPrefix)
                .HasMaxLength(10);

            this.Property(t => t.DpmAsDscnt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SupplCode)
                .HasMaxLength(254);

            this.Property(t => t.GTSRlvnt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SrvTaxRule)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Supplier)
                .HasMaxLength(15);

            this.Property(t => t.ToWhsCode)
                .HasMaxLength(8);

            this.Property(t => t.Requester)
                .HasMaxLength(25);

            this.Property(t => t.ReqName)
                .HasMaxLength(155);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.Notify)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OriginType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IsReuseNum)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IsReuseNFN)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DocDlvry)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IsAlt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AuthCode)
                .HasMaxLength(250);

            this.Property(t => t.VclPlate)
                .HasMaxLength(20);

            this.Property(t => t.ElCoStatus)
                .HasMaxLength(10);

            this.Property(t => t.AtDocType)
                .HasMaxLength(2);

            this.Property(t => t.ElCoMsg)
                .HasMaxLength(254);

            this.Property(t => t.PrintSEPA)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FiscDocNum)
                .HasMaxLength(100);

            this.Property(t => t.PTICode)
                .HasMaxLength(5);

            this.Property(t => t.Letter)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ToBinCode)
                .HasMaxLength(228);

           

            // Table & Column Mappings
            this.ToTable("ORDR");
            this.Property(t => t.DocEntry).HasColumnName("DocEntry");
            this.Property(t => t.DocNum).HasColumnName("DocNum");
            this.Property(t => t.DocType).HasColumnName("DocType");
            this.Property(t => t.CANCELED).HasColumnName("CANCELED");
            this.Property(t => t.Handwrtten).HasColumnName("Handwrtten");
            this.Property(t => t.Printed).HasColumnName("Printed");
            this.Property(t => t.DocStatus).HasColumnName("DocStatus");
            this.Property(t => t.InvntSttus).HasColumnName("InvntSttus");
            this.Property(t => t.Transfered).HasColumnName("Transfered");
            this.Property(t => t.ObjType).HasColumnName("ObjType");
            this.Property(t => t.DocDate).HasColumnName("DocDate");
            this.Property(t => t.DocDueDate).HasColumnName("DocDueDate");
            this.Property(t => t.CardCode).HasColumnName("CardCode");
            this.Property(t => t.CardName).HasColumnName("CardName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.NumAtCard).HasColumnName("NumAtCard");
            this.Property(t => t.VatPercent).HasColumnName("VatPercent");
            this.Property(t => t.VatSum).HasColumnName("VatSum");
            this.Property(t => t.VatSumFC).HasColumnName("VatSumFC");
            this.Property(t => t.DiscPrcnt).HasColumnName("DiscPrcnt");
            this.Property(t => t.DiscSum).HasColumnName("DiscSum");
            this.Property(t => t.DiscSumFC).HasColumnName("DiscSumFC");
            this.Property(t => t.DocCur).HasColumnName("DocCur");
            this.Property(t => t.DocRate).HasColumnName("DocRate");
            this.Property(t => t.DocTotal).HasColumnName("DocTotal");
            this.Property(t => t.DocTotalFC).HasColumnName("DocTotalFC");
            this.Property(t => t.PaidToDate).HasColumnName("PaidToDate");
            this.Property(t => t.PaidFC).HasColumnName("PaidFC");
            this.Property(t => t.GrosProfit).HasColumnName("GrosProfit");
            this.Property(t => t.GrosProfFC).HasColumnName("GrosProfFC");
            this.Property(t => t.Ref1).HasColumnName("Ref1");
            this.Property(t => t.Ref2).HasColumnName("Ref2");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.JrnlMemo).HasColumnName("JrnlMemo");
            this.Property(t => t.TransId).HasColumnName("TransId");
            this.Property(t => t.ReceiptNum).HasColumnName("ReceiptNum");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.DocTime).HasColumnName("DocTime");
            this.Property(t => t.SlpCode).HasColumnName("SlpCode");
            this.Property(t => t.TrnspCode).HasColumnName("TrnspCode");
            this.Property(t => t.PartSupply).HasColumnName("PartSupply");
            this.Property(t => t.Confirmed).HasColumnName("Confirmed");
            this.Property(t => t.GrossBase).HasColumnName("GrossBase");
            this.Property(t => t.ImportEnt).HasColumnName("ImportEnt");
            this.Property(t => t.CreateTran).HasColumnName("CreateTran");
            this.Property(t => t.SummryType).HasColumnName("SummryType");
            this.Property(t => t.UpdInvnt).HasColumnName("UpdInvnt");
            this.Property(t => t.UpdCardBal).HasColumnName("UpdCardBal");
            this.Property(t => t.Instance).HasColumnName("Instance");
            this.Property(t => t.Flags).HasColumnName("Flags");
            this.Property(t => t.InvntDirec).HasColumnName("InvntDirec");
            this.Property(t => t.CntctCode).HasColumnName("CntctCode");
            this.Property(t => t.ShowSCN).HasColumnName("ShowSCN");
            this.Property(t => t.FatherCard).HasColumnName("FatherCard");
            this.Property(t => t.SysRate).HasColumnName("SysRate");
            this.Property(t => t.CurSource).HasColumnName("CurSource");
            this.Property(t => t.VatSumSy).HasColumnName("VatSumSy");
            this.Property(t => t.DiscSumSy).HasColumnName("DiscSumSy");
            this.Property(t => t.DocTotalSy).HasColumnName("DocTotalSy");
            this.Property(t => t.PaidSys).HasColumnName("PaidSys");
            this.Property(t => t.FatherType).HasColumnName("FatherType");
            this.Property(t => t.GrosProfSy).HasColumnName("GrosProfSy");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.IsICT).HasColumnName("IsICT");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.VolUnit).HasColumnName("VolUnit");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit");
            this.Property(t => t.Series).HasColumnName("Series");
            this.Property(t => t.TaxDate).HasColumnName("TaxDate");
            this.Property(t => t.Filler).HasColumnName("Filler");
            this.Property(t => t.DataSource).HasColumnName("DataSource");
            this.Property(t => t.StampNum).HasColumnName("StampNum");
            this.Property(t => t.isCrin).HasColumnName("isCrin");
            this.Property(t => t.FinncPriod).HasColumnName("FinncPriod");
            this.Property(t => t.UserSign).HasColumnName("UserSign");
            this.Property(t => t.selfInv).HasColumnName("selfInv");
            this.Property(t => t.VatPaid).HasColumnName("VatPaid");
            this.Property(t => t.VatPaidFC).HasColumnName("VatPaidFC");
            this.Property(t => t.VatPaidSys).HasColumnName("VatPaidSys");
            this.Property(t => t.UserSign2).HasColumnName("UserSign2");
            this.Property(t => t.WddStatus).HasColumnName("WddStatus");
            this.Property(t => t.draftKey).HasColumnName("draftKey");
            this.Property(t => t.TotalExpns).HasColumnName("TotalExpns");
            this.Property(t => t.TotalExpFC).HasColumnName("TotalExpFC");
            this.Property(t => t.TotalExpSC).HasColumnName("TotalExpSC");
            this.Property(t => t.DunnLevel).HasColumnName("DunnLevel");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.LogInstanc).HasColumnName("LogInstanc");
            this.Property(t => t.Exported).HasColumnName("Exported");
            this.Property(t => t.StationID).HasColumnName("StationID");
            this.Property(t => t.Indicator).HasColumnName("Indicator");
            this.Property(t => t.NetProc).HasColumnName("NetProc");
            this.Property(t => t.AqcsTax).HasColumnName("AqcsTax");
            this.Property(t => t.AqcsTaxFC).HasColumnName("AqcsTaxFC");
            this.Property(t => t.AqcsTaxSC).HasColumnName("AqcsTaxSC");
            this.Property(t => t.CashDiscPr).HasColumnName("CashDiscPr");
            this.Property(t => t.CashDiscnt).HasColumnName("CashDiscnt");
            this.Property(t => t.CashDiscFC).HasColumnName("CashDiscFC");
            this.Property(t => t.CashDiscSC).HasColumnName("CashDiscSC");
            this.Property(t => t.ShipToCode).HasColumnName("ShipToCode");
            this.Property(t => t.LicTradNum).HasColumnName("LicTradNum");
            this.Property(t => t.PaymentRef).HasColumnName("PaymentRef");
            this.Property(t => t.WTSum).HasColumnName("WTSum");
            this.Property(t => t.WTSumFC).HasColumnName("WTSumFC");
            this.Property(t => t.WTSumSC).HasColumnName("WTSumSC");
            this.Property(t => t.RoundDif).HasColumnName("RoundDif");
            this.Property(t => t.RoundDifFC).HasColumnName("RoundDifFC");
            this.Property(t => t.RoundDifSy).HasColumnName("RoundDifSy");
            this.Property(t => t.CheckDigit).HasColumnName("CheckDigit");
            this.Property(t => t.Form1099).HasColumnName("Form1099");
            this.Property(t => t.Box1099).HasColumnName("Box1099");
            this.Property(t => t.submitted).HasColumnName("submitted");
            this.Property(t => t.PoPrss).HasColumnName("PoPrss");
            this.Property(t => t.Rounding).HasColumnName("Rounding");
            this.Property(t => t.RevisionPo).HasColumnName("RevisionPo");
            this.Property(t => t.Segment).HasColumnName("Segment");
            this.Property(t => t.ReqDate).HasColumnName("ReqDate");
            this.Property(t => t.CancelDate).HasColumnName("CancelDate");
            this.Property(t => t.PickStatus).HasColumnName("PickStatus");
            this.Property(t => t.Pick).HasColumnName("Pick");
            this.Property(t => t.BlockDunn).HasColumnName("BlockDunn");
            this.Property(t => t.PeyMethod).HasColumnName("PeyMethod");
            this.Property(t => t.PayBlock).HasColumnName("PayBlock");
            this.Property(t => t.PayBlckRef).HasColumnName("PayBlckRef");
            this.Property(t => t.MaxDscn).HasColumnName("MaxDscn");
            this.Property(t => t.Reserve).HasColumnName("Reserve");
            this.Property(t => t.Max1099).HasColumnName("Max1099");
            this.Property(t => t.CntrlBnk).HasColumnName("CntrlBnk");
            this.Property(t => t.PickRmrk).HasColumnName("PickRmrk");
            this.Property(t => t.ISRCodLine).HasColumnName("ISRCodLine");
            this.Property(t => t.ExpAppl).HasColumnName("ExpAppl");
            this.Property(t => t.ExpApplFC).HasColumnName("ExpApplFC");
            this.Property(t => t.ExpApplSC).HasColumnName("ExpApplSC");
            this.Property(t => t.Project).HasColumnName("Project");
            this.Property(t => t.DeferrTax).HasColumnName("DeferrTax");
            this.Property(t => t.LetterNum).HasColumnName("LetterNum");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.WTApplied).HasColumnName("WTApplied");
            this.Property(t => t.WTAppliedF).HasColumnName("WTAppliedF");
            this.Property(t => t.BoeReserev).HasColumnName("BoeReserev");
            this.Property(t => t.AgentCode).HasColumnName("AgentCode");
            this.Property(t => t.WTAppliedS).HasColumnName("WTAppliedS");
            this.Property(t => t.EquVatSum).HasColumnName("EquVatSum");
            this.Property(t => t.EquVatSumF).HasColumnName("EquVatSumF");
            this.Property(t => t.EquVatSumS).HasColumnName("EquVatSumS");
            this.Property(t => t.Installmnt).HasColumnName("Installmnt");
            this.Property(t => t.VATFirst).HasColumnName("VATFirst");
            this.Property(t => t.NnSbAmnt).HasColumnName("NnSbAmnt");
            this.Property(t => t.NnSbAmntSC).HasColumnName("NnSbAmntSC");
            this.Property(t => t.NbSbAmntFC).HasColumnName("NbSbAmntFC");
            this.Property(t => t.ExepAmnt).HasColumnName("ExepAmnt");
            this.Property(t => t.ExepAmntSC).HasColumnName("ExepAmntSC");
            this.Property(t => t.ExepAmntFC).HasColumnName("ExepAmntFC");
            this.Property(t => t.VatDate).HasColumnName("VatDate");
            this.Property(t => t.CorrExt).HasColumnName("CorrExt");
            this.Property(t => t.CorrInv).HasColumnName("CorrInv");
            this.Property(t => t.NCorrInv).HasColumnName("NCorrInv");
            this.Property(t => t.CEECFlag).HasColumnName("CEECFlag");
            this.Property(t => t.BaseAmnt).HasColumnName("BaseAmnt");
            this.Property(t => t.BaseAmntSC).HasColumnName("BaseAmntSC");
            this.Property(t => t.BaseAmntFC).HasColumnName("BaseAmntFC");
            this.Property(t => t.CtlAccount).HasColumnName("CtlAccount");
            this.Property(t => t.BPLId).HasColumnName("BPLId");
            this.Property(t => t.BPLName).HasColumnName("BPLName");
            this.Property(t => t.VATRegNum).HasColumnName("VATRegNum");
            this.Property(t => t.TxInvRptNo).HasColumnName("TxInvRptNo");
            this.Property(t => t.TxInvRptDt).HasColumnName("TxInvRptDt");
            this.Property(t => t.KVVATCode).HasColumnName("KVVATCode");
            this.Property(t => t.WTDetails).HasColumnName("WTDetails");
            this.Property(t => t.SumAbsId).HasColumnName("SumAbsId");
            this.Property(t => t.SumRptDate).HasColumnName("SumRptDate");
            this.Property(t => t.PIndicator).HasColumnName("PIndicator");
            this.Property(t => t.ManualNum).HasColumnName("ManualNum");
            this.Property(t => t.UseShpdGd).HasColumnName("UseShpdGd");
            this.Property(t => t.BaseVtAt).HasColumnName("BaseVtAt");
            this.Property(t => t.BaseVtAtSC).HasColumnName("BaseVtAtSC");
            this.Property(t => t.BaseVtAtFC).HasColumnName("BaseVtAtFC");
            this.Property(t => t.NnSbVAt).HasColumnName("NnSbVAt");
            this.Property(t => t.NnSbVAtSC).HasColumnName("NnSbVAtSC");
            this.Property(t => t.NbSbVAtFC).HasColumnName("NbSbVAtFC");
            this.Property(t => t.ExptVAt).HasColumnName("ExptVAt");
            this.Property(t => t.ExptVAtSC).HasColumnName("ExptVAtSC");
            this.Property(t => t.ExptVAtFC).HasColumnName("ExptVAtFC");
            this.Property(t => t.LYPmtAt).HasColumnName("LYPmtAt");
            this.Property(t => t.LYPmtAtSC).HasColumnName("LYPmtAtSC");
            this.Property(t => t.LYPmtAtFC).HasColumnName("LYPmtAtFC");
            this.Property(t => t.ExpAnSum).HasColumnName("ExpAnSum");
            this.Property(t => t.ExpAnSys).HasColumnName("ExpAnSys");
            this.Property(t => t.ExpAnFrgn).HasColumnName("ExpAnFrgn");
            this.Property(t => t.DocSubType).HasColumnName("DocSubType");
            this.Property(t => t.DpmStatus).HasColumnName("DpmStatus");
            this.Property(t => t.DpmAmnt).HasColumnName("DpmAmnt");
            this.Property(t => t.DpmAmntSC).HasColumnName("DpmAmntSC");
            this.Property(t => t.DpmAmntFC).HasColumnName("DpmAmntFC");
            this.Property(t => t.DpmDrawn).HasColumnName("DpmDrawn");
            this.Property(t => t.DpmPrcnt).HasColumnName("DpmPrcnt");
            this.Property(t => t.PaidSum).HasColumnName("PaidSum");
            this.Property(t => t.PaidSumFc).HasColumnName("PaidSumFc");
            this.Property(t => t.PaidSumSc).HasColumnName("PaidSumSc");
            this.Property(t => t.FolioPref).HasColumnName("FolioPref");
            this.Property(t => t.FolioNum).HasColumnName("FolioNum");
            this.Property(t => t.DpmAppl).HasColumnName("DpmAppl");
            this.Property(t => t.DpmApplFc).HasColumnName("DpmApplFc");
            this.Property(t => t.DpmApplSc).HasColumnName("DpmApplSc");
            this.Property(t => t.LPgFolioN).HasColumnName("LPgFolioN");
            this.Property(t => t.Header).HasColumnName("Header");
            this.Property(t => t.Footer).HasColumnName("Footer");
            this.Property(t => t.Posted).HasColumnName("Posted");
            this.Property(t => t.OwnerCode).HasColumnName("OwnerCode");
            this.Property(t => t.BPChCode).HasColumnName("BPChCode");
            this.Property(t => t.BPChCntc).HasColumnName("BPChCntc");
            this.Property(t => t.PayToCode).HasColumnName("PayToCode");
            this.Property(t => t.IsPaytoBnk).HasColumnName("IsPaytoBnk");
            this.Property(t => t.BnkCntry).HasColumnName("BnkCntry");
            this.Property(t => t.BankCode).HasColumnName("BankCode");
            this.Property(t => t.BnkAccount).HasColumnName("BnkAccount");
            this.Property(t => t.BnkBranch).HasColumnName("BnkBranch");
            this.Property(t => t.isIns).HasColumnName("isIns");
            this.Property(t => t.TrackNo).HasColumnName("TrackNo");
            this.Property(t => t.VersionNum).HasColumnName("VersionNum");
            this.Property(t => t.LangCode).HasColumnName("LangCode");
            this.Property(t => t.BPNameOW).HasColumnName("BPNameOW");
            this.Property(t => t.BillToOW).HasColumnName("BillToOW");
            this.Property(t => t.ShipToOW).HasColumnName("ShipToOW");
            this.Property(t => t.RetInvoice).HasColumnName("RetInvoice");
            this.Property(t => t.ClsDate).HasColumnName("ClsDate");
            this.Property(t => t.MInvNum).HasColumnName("MInvNum");
            this.Property(t => t.MInvDate).HasColumnName("MInvDate");
            this.Property(t => t.SeqCode).HasColumnName("SeqCode");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.SeriesStr).HasColumnName("SeriesStr");
            this.Property(t => t.SubStr).HasColumnName("SubStr");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.TaxOnExp).HasColumnName("TaxOnExp");
            this.Property(t => t.TaxOnExpFc).HasColumnName("TaxOnExpFc");
            this.Property(t => t.TaxOnExpSc).HasColumnName("TaxOnExpSc");
            this.Property(t => t.TaxOnExAp).HasColumnName("TaxOnExAp");
            this.Property(t => t.TaxOnExApF).HasColumnName("TaxOnExApF");
            this.Property(t => t.TaxOnExApS).HasColumnName("TaxOnExApS");
            this.Property(t => t.LastPmnTyp).HasColumnName("LastPmnTyp");
            this.Property(t => t.LndCstNum).HasColumnName("LndCstNum");
            this.Property(t => t.UseCorrVat).HasColumnName("UseCorrVat");
            this.Property(t => t.BlkCredMmo).HasColumnName("BlkCredMmo");
            this.Property(t => t.OpenForLaC).HasColumnName("OpenForLaC");
            this.Property(t => t.Excised).HasColumnName("Excised");
            this.Property(t => t.ExcRefDate).HasColumnName("ExcRefDate");
            this.Property(t => t.ExcRmvTime).HasColumnName("ExcRmvTime");
            this.Property(t => t.SrvGpPrcnt).HasColumnName("SrvGpPrcnt");
            this.Property(t => t.DepositNum).HasColumnName("DepositNum");
            this.Property(t => t.CertNum).HasColumnName("CertNum");
            this.Property(t => t.DutyStatus).HasColumnName("DutyStatus");
            this.Property(t => t.AutoCrtFlw).HasColumnName("AutoCrtFlw");
            this.Property(t => t.FlwRefDate).HasColumnName("FlwRefDate");
            this.Property(t => t.FlwRefNum).HasColumnName("FlwRefNum");
            this.Property(t => t.VatJENum).HasColumnName("VatJENum");
            this.Property(t => t.DpmVat).HasColumnName("DpmVat");
            this.Property(t => t.DpmVatFc).HasColumnName("DpmVatFc");
            this.Property(t => t.DpmVatSc).HasColumnName("DpmVatSc");
            this.Property(t => t.DpmAppVat).HasColumnName("DpmAppVat");
            this.Property(t => t.DpmAppVatF).HasColumnName("DpmAppVatF");
            this.Property(t => t.DpmAppVatS).HasColumnName("DpmAppVatS");
            this.Property(t => t.InsurOp347).HasColumnName("InsurOp347");
            this.Property(t => t.IgnRelDoc).HasColumnName("IgnRelDoc");
            this.Property(t => t.BuildDesc).HasColumnName("BuildDesc");
            this.Property(t => t.ResidenNum).HasColumnName("ResidenNum");
            this.Property(t => t.Checker).HasColumnName("Checker");
            this.Property(t => t.Payee).HasColumnName("Payee");
            this.Property(t => t.CopyNumber).HasColumnName("CopyNumber");
            this.Property(t => t.SSIExmpt).HasColumnName("SSIExmpt");
            this.Property(t => t.PQTGrpSer).HasColumnName("PQTGrpSer");
            this.Property(t => t.PQTGrpNum).HasColumnName("PQTGrpNum");
            this.Property(t => t.PQTGrpHW).HasColumnName("PQTGrpHW");
            this.Property(t => t.ReopOriDoc).HasColumnName("ReopOriDoc");
            this.Property(t => t.ReopManCls).HasColumnName("ReopManCls");
            this.Property(t => t.DocManClsd).HasColumnName("DocManClsd");
            this.Property(t => t.ClosingOpt).HasColumnName("ClosingOpt");
            this.Property(t => t.SpecDate).HasColumnName("SpecDate");
            this.Property(t => t.Ordered).HasColumnName("Ordered");
            this.Property(t => t.NTSApprov).HasColumnName("NTSApprov");
            this.Property(t => t.NTSWebSite).HasColumnName("NTSWebSite");
            this.Property(t => t.NTSeTaxNo).HasColumnName("NTSeTaxNo");
            this.Property(t => t.NTSApprNo).HasColumnName("NTSApprNo");
            this.Property(t => t.PayDuMonth).HasColumnName("PayDuMonth");
            this.Property(t => t.ExtraMonth).HasColumnName("ExtraMonth");
            this.Property(t => t.ExtraDays).HasColumnName("ExtraDays");
            this.Property(t => t.CdcOffset).HasColumnName("CdcOffset");
            this.Property(t => t.SignMsg).HasColumnName("SignMsg");
            this.Property(t => t.SignDigest).HasColumnName("SignDigest");
            this.Property(t => t.CertifNum).HasColumnName("CertifNum");
            this.Property(t => t.KeyVersion).HasColumnName("KeyVersion");
            this.Property(t => t.EDocGenTyp).HasColumnName("EDocGenTyp");
            this.Property(t => t.ESeries).HasColumnName("ESeries");
            this.Property(t => t.EDocNum).HasColumnName("EDocNum");
            this.Property(t => t.EDocExpFrm).HasColumnName("EDocExpFrm");
            this.Property(t => t.OnlineQuo).HasColumnName("OnlineQuo");
            this.Property(t => t.POSEqNum).HasColumnName("POSEqNum");
            this.Property(t => t.POSManufSN).HasColumnName("POSManufSN");
            this.Property(t => t.POSCashN).HasColumnName("POSCashN");
            this.Property(t => t.EDocStatus).HasColumnName("EDocStatus");
            this.Property(t => t.EDocCntnt).HasColumnName("EDocCntnt");
            this.Property(t => t.EDocProces).HasColumnName("EDocProces");
            this.Property(t => t.EDocErrCod).HasColumnName("EDocErrCod");
            this.Property(t => t.EDocErrMsg).HasColumnName("EDocErrMsg");
            this.Property(t => t.EDocCancel).HasColumnName("EDocCancel");
            this.Property(t => t.EDocTest).HasColumnName("EDocTest");
            this.Property(t => t.EDocPrefix).HasColumnName("EDocPrefix");
            this.Property(t => t.CUP).HasColumnName("CUP");
            this.Property(t => t.CIG).HasColumnName("CIG");
            this.Property(t => t.DpmAsDscnt).HasColumnName("DpmAsDscnt");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.AtcEntry).HasColumnName("AtcEntry");
            this.Property(t => t.SupplCode).HasColumnName("SupplCode");
            this.Property(t => t.GTSRlvnt).HasColumnName("GTSRlvnt");
            this.Property(t => t.BaseDisc).HasColumnName("BaseDisc");
            this.Property(t => t.BaseDiscSc).HasColumnName("BaseDiscSc");
            this.Property(t => t.BaseDiscFc).HasColumnName("BaseDiscFc");
            this.Property(t => t.BaseDiscPr).HasColumnName("BaseDiscPr");
            this.Property(t => t.CreateTS).HasColumnName("CreateTS");
            this.Property(t => t.UpdateTS).HasColumnName("UpdateTS");
            this.Property(t => t.SrvTaxRule).HasColumnName("SrvTaxRule");
            this.Property(t => t.AnnInvDecR).HasColumnName("AnnInvDecR");
            this.Property(t => t.Supplier).HasColumnName("Supplier");
            this.Property(t => t.Releaser).HasColumnName("Releaser");
            this.Property(t => t.Receiver).HasColumnName("Receiver");
            this.Property(t => t.ToWhsCode).HasColumnName("ToWhsCode");
            this.Property(t => t.AssetDate).HasColumnName("AssetDate");
            this.Property(t => t.Requester).HasColumnName("Requester");
            this.Property(t => t.ReqName).HasColumnName("ReqName");
            this.Property(t => t.Branch).HasColumnName("Branch");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Notify).HasColumnName("Notify");
            this.Property(t => t.ReqType).HasColumnName("ReqType");
            this.Property(t => t.OriginType).HasColumnName("OriginType");
            this.Property(t => t.IsReuseNum).HasColumnName("IsReuseNum");
            this.Property(t => t.IsReuseNFN).HasColumnName("IsReuseNFN");
            this.Property(t => t.DocDlvry).HasColumnName("DocDlvry");
            this.Property(t => t.PaidDpm).HasColumnName("PaidDpm");
            this.Property(t => t.PaidDpmF).HasColumnName("PaidDpmF");
            this.Property(t => t.PaidDpmS).HasColumnName("PaidDpmS");
            this.Property(t => t.EnvTypeNFe).HasColumnName("EnvTypeNFe");
            this.Property(t => t.AgrNo).HasColumnName("AgrNo");
            this.Property(t => t.IsAlt).HasColumnName("IsAlt");
            this.Property(t => t.AltBaseTyp).HasColumnName("AltBaseTyp");
            this.Property(t => t.AltBaseEnt).HasColumnName("AltBaseEnt");
            this.Property(t => t.AuthCode).HasColumnName("AuthCode");
            this.Property(t => t.StDlvDate).HasColumnName("StDlvDate");
            this.Property(t => t.StDlvTime).HasColumnName("StDlvTime");
            this.Property(t => t.EndDlvDate).HasColumnName("EndDlvDate");
            this.Property(t => t.EndDlvTime).HasColumnName("EndDlvTime");
            this.Property(t => t.VclPlate).HasColumnName("VclPlate");
            this.Property(t => t.ElCoStatus).HasColumnName("ElCoStatus");
            this.Property(t => t.AtDocType).HasColumnName("AtDocType");
            this.Property(t => t.ElCoMsg).HasColumnName("ElCoMsg");
            this.Property(t => t.PrintSEPA).HasColumnName("PrintSEPA");
            this.Property(t => t.FreeChrg).HasColumnName("FreeChrg");
            this.Property(t => t.FreeChrgFC).HasColumnName("FreeChrgFC");
            this.Property(t => t.FreeChrgSC).HasColumnName("FreeChrgSC");
            this.Property(t => t.NfeValue).HasColumnName("NfeValue");
            this.Property(t => t.FiscDocNum).HasColumnName("FiscDocNum");
            this.Property(t => t.RelatedTyp).HasColumnName("RelatedTyp");
            this.Property(t => t.RelatedEnt).HasColumnName("RelatedEnt");
            this.Property(t => t.CCDEntry).HasColumnName("CCDEntry");
            this.Property(t => t.NfePrntFo).HasColumnName("NfePrntFo");
            this.Property(t => t.ZrdAbs).HasColumnName("ZrdAbs");
            this.Property(t => t.POSRcptNo).HasColumnName("POSRcptNo");
            this.Property(t => t.FoCTax).HasColumnName("FoCTax");
            this.Property(t => t.FoCTaxFC).HasColumnName("FoCTaxFC");
            this.Property(t => t.FoCTaxSC).HasColumnName("FoCTaxSC");
            this.Property(t => t.TpCusPres).HasColumnName("TpCusPres");
            this.Property(t => t.ExcDocDate).HasColumnName("ExcDocDate");
            this.Property(t => t.FoCFrght).HasColumnName("FoCFrght");
            this.Property(t => t.FoCFrghtFC).HasColumnName("FoCFrghtFC");
            this.Property(t => t.FoCFrghtSC).HasColumnName("FoCFrghtSC");
            this.Property(t => t.InterimTyp).HasColumnName("InterimTyp");
            this.Property(t => t.PTICode).HasColumnName("PTICode");
            this.Property(t => t.Letter).HasColumnName("Letter");
            this.Property(t => t.FolNumFrom).HasColumnName("FolNumFrom");
            this.Property(t => t.FolNumTo).HasColumnName("FolNumTo");
            this.Property(t => t.FolSeries).HasColumnName("FolSeries");
            this.Property(t => t.SplitTax).HasColumnName("SplitTax");
            this.Property(t => t.SplitTaxFC).HasColumnName("SplitTaxFC");
            this.Property(t => t.SplitTaxSC).HasColumnName("SplitTaxSC");
            this.Property(t => t.ToBinCode).HasColumnName("ToBinCode");
        }
    }
}
