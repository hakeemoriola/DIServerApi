using System.Data.Entity.ModelConfiguration;

namespace NHPApi.Models.Mapping
{
    public class OCRDMap : EntityTypeConfiguration<OCRD>
    {
        public OCRDMap()
        {
            // Primary Key
            this.HasKey(t => t.CardCode);

            // Properties
            this.Property(t => t.CardCode)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.CardName)
                .HasMaxLength(100);

            this.Property(t => t.CardType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CmpPrivate)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            this.Property(t => t.ZipCode)
                .HasMaxLength(20);

            this.Property(t => t.MailAddres)
                .HasMaxLength(100);

            this.Property(t => t.MailZipCod)
                .HasMaxLength(20);

            this.Property(t => t.Phone1)
                .HasMaxLength(20);

            this.Property(t => t.Phone2)
                .HasMaxLength(20);

            this.Property(t => t.Fax)
                .HasMaxLength(20);

            this.Property(t => t.CntctPrsn)
                .HasMaxLength(90);

            this.Property(t => t.Notes)
                .HasMaxLength(100);

            this.Property(t => t.VatStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LicTradNum)
                .HasMaxLength(32);

            this.Property(t => t.DdctStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Transfered)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BalTrnsfrd)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PrevYearAc)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Currency)
                .HasMaxLength(3);

            this.Property(t => t.RateDifAct)
                .HasMaxLength(15);

            this.Property(t => t.Protected)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Cellular)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(100);

            this.Property(t => t.County)
                .HasMaxLength(100);

            this.Property(t => t.Country)
                .HasMaxLength(3);

            this.Property(t => t.MailCity)
                .HasMaxLength(100);

            this.Property(t => t.MailCounty)
                .HasMaxLength(100);

            this.Property(t => t.MailCountr)
                .HasMaxLength(3);

            this.Property(t => t.E_Mail)
                .HasMaxLength(100);

            this.Property(t => t.Picture)
                .HasMaxLength(200);

            this.Property(t => t.DflAccount)
                .HasMaxLength(50);

            this.Property(t => t.DflBranch)
                .HasMaxLength(50);

            this.Property(t => t.BankCode)
                .HasMaxLength(30);

            this.Property(t => t.AddID)
                .HasMaxLength(64);

            this.Property(t => t.Pager)
                .HasMaxLength(30);

            this.Property(t => t.FatherCard)
                .HasMaxLength(15);

            this.Property(t => t.CardFName)
                .HasMaxLength(100);

            this.Property(t => t.FatherType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup1)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup2)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup3)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup4)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup5)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup6)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup7)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup8)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup9)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup10)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup11)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup12)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup13)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup14)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup15)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup16)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup17)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup18)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup19)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup20)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup21)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup22)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup23)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup24)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup25)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup26)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup27)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup28)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup29)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup30)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup31)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup32)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup33)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup34)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup35)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup36)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup37)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup38)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup39)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup40)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup41)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup42)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup43)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup44)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup45)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup46)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup47)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup48)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup49)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup50)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup51)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup52)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup53)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup54)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup55)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup56)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup57)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup58)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup59)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup60)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup61)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup62)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup63)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.QryGroup64)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DdctOffice)
                .HasMaxLength(10);

            this.Property(t => t.ExportCode)
                .HasMaxLength(8);

            this.Property(t => t.DscntRel)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DdctFileNo)
                .HasMaxLength(9);

            this.Property(t => t.DataSource)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ExemptNo)
                .HasMaxLength(50);

            this.Property(t => t.CrCardNum)
                .HasMaxLength(64);

            this.Property(t => t.LocMth)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.validFor)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.frozenFor)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sEmployed)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ValidComm)
                .HasMaxLength(30);

            this.Property(t => t.FrozenComm)
                .HasMaxLength(30);

            this.Property(t => t.chainStore)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DiscInRet)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.State1)
                .HasMaxLength(3);

            this.Property(t => t.State2)
                .HasMaxLength(3);

            this.Property(t => t.VatGroup)
                .HasMaxLength(8);

            this.Property(t => t.ObjType)
                .HasMaxLength(20);

            this.Property(t => t.Indicator)
                .HasMaxLength(2);

            this.Property(t => t.DebPayAcct)
                .HasMaxLength(15);

            this.Property(t => t.ShipToDef)
                .HasMaxLength(50);

            this.Property(t => t.Block)
                .HasMaxLength(100);

            this.Property(t => t.MailBlock)
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .HasMaxLength(32);

            this.Property(t => t.ECVatGroup)
                .HasMaxLength(8);

            this.Property(t => t.Deleted)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IBAN)
                .HasMaxLength(50);

            this.Property(t => t.Box1099)
                .HasMaxLength(20);

            this.Property(t => t.PymCode)
                .HasMaxLength(15);

            this.Property(t => t.BackOrder)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PartDelivr)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BlockDunn)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BankCountr)
                .HasMaxLength(3);

            this.Property(t => t.CollecAuth)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DME)
                .HasMaxLength(5);

            this.Property(t => t.InstrucKey)
                .HasMaxLength(30);

            this.Property(t => t.SinglePaym)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ISRBillId)
                .HasMaxLength(9);

            this.Property(t => t.PaymBlock)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RefDetails)
                .HasMaxLength(20);

            this.Property(t => t.HouseBank)
                .HasMaxLength(30);

            this.Property(t => t.OwnerIdNum)
                .HasMaxLength(15);

            this.Property(t => t.HousBnkCry)
                .HasMaxLength(3);

            this.Property(t => t.HousBnkAct)
                .HasMaxLength(50);

            this.Property(t => t.HousBnkBrn)
                .HasMaxLength(50);

            this.Property(t => t.ProjectCod)
                .HasMaxLength(20);

            this.Property(t => t.VatIdUnCmp)
                .HasMaxLength(32);

            this.Property(t => t.AgentCode)
                .HasMaxLength(32);

            this.Property(t => t.SelfInvoic)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DeferrTax)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LetterNum)
                .HasMaxLength(20);

            this.Property(t => t.WTLiable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CrtfcateNO)
                .HasMaxLength(20);

            this.Property(t => t.NINum)
                .HasMaxLength(20);

            this.Property(t => t.AccCritria)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WTCode)
                .HasMaxLength(4);

            this.Property(t => t.Equ)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.HldCode)
                .HasMaxLength(20);

            this.Property(t => t.ConnBP)
                .HasMaxLength(15);

            this.Property(t => t.TypWTReprt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VATRegNum)
                .HasMaxLength(32);

            this.Property(t => t.RepName)
                .HasMaxLength(15);

            this.Property(t => t.IsDomestic)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IsResident)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AutoCalBCG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OtrCtlAcct)
                .HasMaxLength(15);

            this.Property(t => t.BoEPrsnt)
                .HasMaxLength(15);

            this.Property(t => t.BoEDiscnt)
                .HasMaxLength(15);

            this.Property(t => t.BoEOnClct)
                .HasMaxLength(15);

            this.Property(t => t.UnpaidBoE)
                .HasMaxLength(15);

            this.Property(t => t.ITWTCode)
                .HasMaxLength(4);

            this.Property(t => t.DunTerm)
                .HasMaxLength(25);

            this.Property(t => t.ChannlBP)
                .HasMaxLength(15);

            this.Property(t => t.BillToDef)
                .HasMaxLength(50);

            this.Property(t => t.DpmClear)
                .HasMaxLength(15);

            this.Property(t => t.IntrntSite)
                .HasMaxLength(100);

            this.Property(t => t.Profession)
                .HasMaxLength(50);

            this.Property(t => t.BCACode)
                .HasMaxLength(3);

            this.Property(t => t.UseShpdGd)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RegNum)
                .HasMaxLength(32);

            this.Property(t => t.VerifNum)
                .HasMaxLength(32);

            this.Property(t => t.BankCtlKey)
                .HasMaxLength(2);

            this.Property(t => t.HousCtlKey)
                .HasMaxLength(2);

            this.Property(t => t.AddrType)
                .HasMaxLength(100);

            this.Property(t => t.InsurOp347)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MailAddrTy)
                .HasMaxLength(100);

            this.Property(t => t.StreetNo)
                .HasMaxLength(100);

            this.Property(t => t.MailStrNo)
                .HasMaxLength(100);

            this.Property(t => t.TaxRndRule)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ThreshOver)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SurOver)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VendorOcup)
                .HasMaxLength(15);

            this.Property(t => t.OpCode347)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DpmIntAct)
                .HasMaxLength(15);

            this.Property(t => t.ResidenNum)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PlngGroup)
                .HasMaxLength(10);

            this.Property(t => t.VatIDNum)
                .HasMaxLength(32);

            this.Property(t => t.Affiliate)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MivzExpSts)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.HierchDdct)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CertWHT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CertBKeep)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WHShaamGrp)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DatevFirst)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GTSRegNum)
                .HasMaxLength(20);

            this.Property(t => t.GTSBankAct)
                .HasMaxLength(80);

            this.Property(t => t.GTSBilAddr)
                .HasMaxLength(80);

            this.Property(t => t.HsBnkSwift)
                .HasMaxLength(50);

            this.Property(t => t.HsBnkIBAN)
                .HasMaxLength(50);

            this.Property(t => t.DflSwift)
                .HasMaxLength(50);

            this.Property(t => t.AutoPost)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IntrAcc)
                .HasMaxLength(15);

            this.Property(t => t.FeeAcc)
                .HasMaxLength(15);

            this.Property(t => t.DflIBAN)
                .HasMaxLength(50);

            this.Property(t => t.TaxIdIdent)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DiscRel)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NoDiscount)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SCAdjust)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GlblLocNum)
                .HasMaxLength(50);

            this.Property(t => t.SenderID)
                .HasMaxLength(50);

            this.Property(t => t.RcpntID)
                .HasMaxLength(50);

            this.Property(t => t.SefazCheck)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.free312)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.free313)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RelCode)
                .HasMaxLength(2);

            this.Property(t => t.OKATO)
                .HasMaxLength(11);

            this.Property(t => t.OKTMO)
                .HasMaxLength(12);

            this.Property(t => t.KBKCode)
                .HasMaxLength(20);

            this.Property(t => t.TypeOfOp)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MandateID)
                .HasMaxLength(35);

            this.Property(t => t.ConCerti)
                .HasMaxLength(20);

            this.Property(t => t.RoleTypCod)
                .HasMaxLength(2);

            this.Property(t => t.BlockComm)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EmplymntCt)
                .HasMaxLength(2);

            this.Property(t => t.ExcptnlEvt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EdrsFromBP)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EdrsToBP)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EDocGenTyp)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("OCRD");
            this.Property(t => t.CardCode).HasColumnName("CardCode");
            this.Property(t => t.CardName).HasColumnName("CardName");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.GroupCode).HasColumnName("GroupCode");
            this.Property(t => t.CmpPrivate).HasColumnName("CmpPrivate");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.MailAddres).HasColumnName("MailAddres");
            this.Property(t => t.MailZipCod).HasColumnName("MailZipCod");
            this.Property(t => t.Phone1).HasColumnName("Phone1");
            this.Property(t => t.Phone2).HasColumnName("Phone2");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.CntctPrsn).HasColumnName("CntctPrsn");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Balance).HasColumnName("Balance");
            this.Property(t => t.ChecksBal).HasColumnName("ChecksBal");
            this.Property(t => t.DNotesBal).HasColumnName("DNotesBal");
            this.Property(t => t.OrdersBal).HasColumnName("OrdersBal");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.CreditLine).HasColumnName("CreditLine");
            this.Property(t => t.DebtLine).HasColumnName("DebtLine");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.VatStatus).HasColumnName("VatStatus");
            this.Property(t => t.LicTradNum).HasColumnName("LicTradNum");
            this.Property(t => t.DdctStatus).HasColumnName("DdctStatus");
            this.Property(t => t.DdctPrcnt).HasColumnName("DdctPrcnt");
            this.Property(t => t.ValidUntil).HasColumnName("ValidUntil");
            this.Property(t => t.Chrctrstcs).HasColumnName("Chrctrstcs");
            this.Property(t => t.ExMatchNum).HasColumnName("ExMatchNum");
            this.Property(t => t.InMatchNum).HasColumnName("InMatchNum");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.DNoteBalFC).HasColumnName("DNoteBalFC");
            this.Property(t => t.OrderBalFC).HasColumnName("OrderBalFC");
            this.Property(t => t.DNoteBalSy).HasColumnName("DNoteBalSy");
            this.Property(t => t.OrderBalSy).HasColumnName("OrderBalSy");
            this.Property(t => t.Transfered).HasColumnName("Transfered");
            this.Property(t => t.BalTrnsfrd).HasColumnName("BalTrnsfrd");
            this.Property(t => t.IntrstRate).HasColumnName("IntrstRate");
            this.Property(t => t.Commission).HasColumnName("Commission");
            this.Property(t => t.CommGrCode).HasColumnName("CommGrCode");
            this.Property(t => t.Free_Text).HasColumnName("Free_Text");
            this.Property(t => t.SlpCode).HasColumnName("SlpCode");
            this.Property(t => t.PrevYearAc).HasColumnName("PrevYearAc");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.RateDifAct).HasColumnName("RateDifAct");
            this.Property(t => t.BalanceSys).HasColumnName("BalanceSys");
            this.Property(t => t.BalanceFC).HasColumnName("BalanceFC");
            this.Property(t => t.Protected).HasColumnName("Protected");
            this.Property(t => t.Cellular).HasColumnName("Cellular");
            this.Property(t => t.AvrageLate).HasColumnName("AvrageLate");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.County).HasColumnName("County");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.MailCity).HasColumnName("MailCity");
            this.Property(t => t.MailCounty).HasColumnName("MailCounty");
            this.Property(t => t.MailCountr).HasColumnName("MailCountr");
            this.Property(t => t.E_Mail).HasColumnName("E_Mail");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.DflAccount).HasColumnName("DflAccount");
            this.Property(t => t.DflBranch).HasColumnName("DflBranch");
            this.Property(t => t.BankCode).HasColumnName("BankCode");
            this.Property(t => t.AddID).HasColumnName("AddID");
            this.Property(t => t.Pager).HasColumnName("Pager");
            this.Property(t => t.FatherCard).HasColumnName("FatherCard");
            this.Property(t => t.CardFName).HasColumnName("CardFName");
            this.Property(t => t.FatherType).HasColumnName("FatherType");
            this.Property(t => t.QryGroup1).HasColumnName("QryGroup1");
            this.Property(t => t.QryGroup2).HasColumnName("QryGroup2");
            this.Property(t => t.QryGroup3).HasColumnName("QryGroup3");
            this.Property(t => t.QryGroup4).HasColumnName("QryGroup4");
            this.Property(t => t.QryGroup5).HasColumnName("QryGroup5");
            this.Property(t => t.QryGroup6).HasColumnName("QryGroup6");
            this.Property(t => t.QryGroup7).HasColumnName("QryGroup7");
            this.Property(t => t.QryGroup8).HasColumnName("QryGroup8");
            this.Property(t => t.QryGroup9).HasColumnName("QryGroup9");
            this.Property(t => t.QryGroup10).HasColumnName("QryGroup10");
            this.Property(t => t.QryGroup11).HasColumnName("QryGroup11");
            this.Property(t => t.QryGroup12).HasColumnName("QryGroup12");
            this.Property(t => t.QryGroup13).HasColumnName("QryGroup13");
            this.Property(t => t.QryGroup14).HasColumnName("QryGroup14");
            this.Property(t => t.QryGroup15).HasColumnName("QryGroup15");
            this.Property(t => t.QryGroup16).HasColumnName("QryGroup16");
            this.Property(t => t.QryGroup17).HasColumnName("QryGroup17");
            this.Property(t => t.QryGroup18).HasColumnName("QryGroup18");
            this.Property(t => t.QryGroup19).HasColumnName("QryGroup19");
            this.Property(t => t.QryGroup20).HasColumnName("QryGroup20");
            this.Property(t => t.QryGroup21).HasColumnName("QryGroup21");
            this.Property(t => t.QryGroup22).HasColumnName("QryGroup22");
            this.Property(t => t.QryGroup23).HasColumnName("QryGroup23");
            this.Property(t => t.QryGroup24).HasColumnName("QryGroup24");
            this.Property(t => t.QryGroup25).HasColumnName("QryGroup25");
            this.Property(t => t.QryGroup26).HasColumnName("QryGroup26");
            this.Property(t => t.QryGroup27).HasColumnName("QryGroup27");
            this.Property(t => t.QryGroup28).HasColumnName("QryGroup28");
            this.Property(t => t.QryGroup29).HasColumnName("QryGroup29");
            this.Property(t => t.QryGroup30).HasColumnName("QryGroup30");
            this.Property(t => t.QryGroup31).HasColumnName("QryGroup31");
            this.Property(t => t.QryGroup32).HasColumnName("QryGroup32");
            this.Property(t => t.QryGroup33).HasColumnName("QryGroup33");
            this.Property(t => t.QryGroup34).HasColumnName("QryGroup34");
            this.Property(t => t.QryGroup35).HasColumnName("QryGroup35");
            this.Property(t => t.QryGroup36).HasColumnName("QryGroup36");
            this.Property(t => t.QryGroup37).HasColumnName("QryGroup37");
            this.Property(t => t.QryGroup38).HasColumnName("QryGroup38");
            this.Property(t => t.QryGroup39).HasColumnName("QryGroup39");
            this.Property(t => t.QryGroup40).HasColumnName("QryGroup40");
            this.Property(t => t.QryGroup41).HasColumnName("QryGroup41");
            this.Property(t => t.QryGroup42).HasColumnName("QryGroup42");
            this.Property(t => t.QryGroup43).HasColumnName("QryGroup43");
            this.Property(t => t.QryGroup44).HasColumnName("QryGroup44");
            this.Property(t => t.QryGroup45).HasColumnName("QryGroup45");
            this.Property(t => t.QryGroup46).HasColumnName("QryGroup46");
            this.Property(t => t.QryGroup47).HasColumnName("QryGroup47");
            this.Property(t => t.QryGroup48).HasColumnName("QryGroup48");
            this.Property(t => t.QryGroup49).HasColumnName("QryGroup49");
            this.Property(t => t.QryGroup50).HasColumnName("QryGroup50");
            this.Property(t => t.QryGroup51).HasColumnName("QryGroup51");
            this.Property(t => t.QryGroup52).HasColumnName("QryGroup52");
            this.Property(t => t.QryGroup53).HasColumnName("QryGroup53");
            this.Property(t => t.QryGroup54).HasColumnName("QryGroup54");
            this.Property(t => t.QryGroup55).HasColumnName("QryGroup55");
            this.Property(t => t.QryGroup56).HasColumnName("QryGroup56");
            this.Property(t => t.QryGroup57).HasColumnName("QryGroup57");
            this.Property(t => t.QryGroup58).HasColumnName("QryGroup58");
            this.Property(t => t.QryGroup59).HasColumnName("QryGroup59");
            this.Property(t => t.QryGroup60).HasColumnName("QryGroup60");
            this.Property(t => t.QryGroup61).HasColumnName("QryGroup61");
            this.Property(t => t.QryGroup62).HasColumnName("QryGroup62");
            this.Property(t => t.QryGroup63).HasColumnName("QryGroup63");
            this.Property(t => t.QryGroup64).HasColumnName("QryGroup64");
            this.Property(t => t.DdctOffice).HasColumnName("DdctOffice");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.ExportCode).HasColumnName("ExportCode");
            this.Property(t => t.DscntObjct).HasColumnName("DscntObjct");
            this.Property(t => t.DscntRel).HasColumnName("DscntRel");
            this.Property(t => t.SPGCounter).HasColumnName("SPGCounter");
            this.Property(t => t.SPPCounter).HasColumnName("SPPCounter");
            this.Property(t => t.DdctFileNo).HasColumnName("DdctFileNo");
            this.Property(t => t.SCNCounter).HasColumnName("SCNCounter");
            this.Property(t => t.MinIntrst).HasColumnName("MinIntrst");
            this.Property(t => t.DataSource).HasColumnName("DataSource");
            this.Property(t => t.OprCount).HasColumnName("OprCount");
            this.Property(t => t.ExemptNo).HasColumnName("ExemptNo");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.CreditCard).HasColumnName("CreditCard");
            this.Property(t => t.CrCardNum).HasColumnName("CrCardNum");
            this.Property(t => t.CardValid).HasColumnName("CardValid");
            this.Property(t => t.UserSign).HasColumnName("UserSign");
            this.Property(t => t.LocMth).HasColumnName("LocMth");
            this.Property(t => t.validFor).HasColumnName("validFor");
            this.Property(t => t.validFrom).HasColumnName("validFrom");
            this.Property(t => t.validTo).HasColumnName("validTo");
            this.Property(t => t.frozenFor).HasColumnName("frozenFor");
            this.Property(t => t.frozenFrom).HasColumnName("frozenFrom");
            this.Property(t => t.frozenTo).HasColumnName("frozenTo");
            this.Property(t => t.sEmployed).HasColumnName("sEmployed");
            this.Property(t => t.MTHCounter).HasColumnName("MTHCounter");
            this.Property(t => t.BNKCounter).HasColumnName("BNKCounter");
            this.Property(t => t.DdgKey).HasColumnName("DdgKey");
            this.Property(t => t.DdtKey).HasColumnName("DdtKey");
            this.Property(t => t.ValidComm).HasColumnName("ValidComm");
            this.Property(t => t.FrozenComm).HasColumnName("FrozenComm");
            this.Property(t => t.chainStore).HasColumnName("chainStore");
            this.Property(t => t.DiscInRet).HasColumnName("DiscInRet");
            this.Property(t => t.State1).HasColumnName("State1");
            this.Property(t => t.State2).HasColumnName("State2");
            this.Property(t => t.VatGroup).HasColumnName("VatGroup");
            this.Property(t => t.LogInstanc).HasColumnName("LogInstanc");
            this.Property(t => t.ObjType).HasColumnName("ObjType");
            this.Property(t => t.Indicator).HasColumnName("Indicator");
            this.Property(t => t.ShipType).HasColumnName("ShipType");
            this.Property(t => t.DebPayAcct).HasColumnName("DebPayAcct");
            this.Property(t => t.ShipToDef).HasColumnName("ShipToDef");
            this.Property(t => t.Block).HasColumnName("Block");
            this.Property(t => t.MailBlock).HasColumnName("MailBlock");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.ECVatGroup).HasColumnName("ECVatGroup");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.IBAN).HasColumnName("IBAN");
            this.Property(t => t.DocEntry).HasColumnName("DocEntry");
            this.Property(t => t.FormCode).HasColumnName("FormCode");
            this.Property(t => t.Box1099).HasColumnName("Box1099");
            this.Property(t => t.PymCode).HasColumnName("PymCode");
            this.Property(t => t.BackOrder).HasColumnName("BackOrder");
            this.Property(t => t.PartDelivr).HasColumnName("PartDelivr");
            this.Property(t => t.DunnLevel).HasColumnName("DunnLevel");
            this.Property(t => t.DunnDate).HasColumnName("DunnDate");
            this.Property(t => t.BlockDunn).HasColumnName("BlockDunn");
            this.Property(t => t.BankCountr).HasColumnName("BankCountr");
            this.Property(t => t.CollecAuth).HasColumnName("CollecAuth");
            this.Property(t => t.DME).HasColumnName("DME");
            this.Property(t => t.InstrucKey).HasColumnName("InstrucKey");
            this.Property(t => t.SinglePaym).HasColumnName("SinglePaym");
            this.Property(t => t.ISRBillId).HasColumnName("ISRBillId");
            this.Property(t => t.PaymBlock).HasColumnName("PaymBlock");
            this.Property(t => t.RefDetails).HasColumnName("RefDetails");
            this.Property(t => t.HouseBank).HasColumnName("HouseBank");
            this.Property(t => t.OwnerIdNum).HasColumnName("OwnerIdNum");
            this.Property(t => t.PyBlckDesc).HasColumnName("PyBlckDesc");
            this.Property(t => t.HousBnkCry).HasColumnName("HousBnkCry");
            this.Property(t => t.HousBnkAct).HasColumnName("HousBnkAct");
            this.Property(t => t.HousBnkBrn).HasColumnName("HousBnkBrn");
            this.Property(t => t.ProjectCod).HasColumnName("ProjectCod");
            this.Property(t => t.SysMatchNo).HasColumnName("SysMatchNo");
            this.Property(t => t.VatIdUnCmp).HasColumnName("VatIdUnCmp");
            this.Property(t => t.AgentCode).HasColumnName("AgentCode");
            this.Property(t => t.TolrncDays).HasColumnName("TolrncDays");
            this.Property(t => t.SelfInvoic).HasColumnName("SelfInvoic");
            this.Property(t => t.DeferrTax).HasColumnName("DeferrTax");
            this.Property(t => t.LetterNum).HasColumnName("LetterNum");
            this.Property(t => t.MaxAmount).HasColumnName("MaxAmount");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.WTLiable).HasColumnName("WTLiable");
            this.Property(t => t.CrtfcateNO).HasColumnName("CrtfcateNO");
            this.Property(t => t.ExpireDate).HasColumnName("ExpireDate");
            this.Property(t => t.NINum).HasColumnName("NINum");
            this.Property(t => t.AccCritria).HasColumnName("AccCritria");
            this.Property(t => t.WTCode).HasColumnName("WTCode");
            this.Property(t => t.Equ).HasColumnName("Equ");
            this.Property(t => t.HldCode).HasColumnName("HldCode");
            this.Property(t => t.ConnBP).HasColumnName("ConnBP");
            this.Property(t => t.MltMthNum).HasColumnName("MltMthNum");
            this.Property(t => t.TypWTReprt).HasColumnName("TypWTReprt");
            this.Property(t => t.VATRegNum).HasColumnName("VATRegNum");
            this.Property(t => t.RepName).HasColumnName("RepName");
            this.Property(t => t.Industry).HasColumnName("Industry");
            this.Property(t => t.Business).HasColumnName("Business");
            this.Property(t => t.WTTaxCat).HasColumnName("WTTaxCat");
            this.Property(t => t.IsDomestic).HasColumnName("IsDomestic");
            this.Property(t => t.IsResident).HasColumnName("IsResident");
            this.Property(t => t.AutoCalBCG).HasColumnName("AutoCalBCG");
            this.Property(t => t.OtrCtlAcct).HasColumnName("OtrCtlAcct");
            this.Property(t => t.AliasName).HasColumnName("AliasName");
            this.Property(t => t.Building).HasColumnName("Building");
            this.Property(t => t.MailBuildi).HasColumnName("MailBuildi");
            this.Property(t => t.BoEPrsnt).HasColumnName("BoEPrsnt");
            this.Property(t => t.BoEDiscnt).HasColumnName("BoEDiscnt");
            this.Property(t => t.BoEOnClct).HasColumnName("BoEOnClct");
            this.Property(t => t.UnpaidBoE).HasColumnName("UnpaidBoE");
            this.Property(t => t.ITWTCode).HasColumnName("ITWTCode");
            this.Property(t => t.DunTerm).HasColumnName("DunTerm");
            this.Property(t => t.ChannlBP).HasColumnName("ChannlBP");
            this.Property(t => t.DfTcnician).HasColumnName("DfTcnician");
            this.Property(t => t.Territory).HasColumnName("Territory");
            this.Property(t => t.BillToDef).HasColumnName("BillToDef");
            this.Property(t => t.DpmClear).HasColumnName("DpmClear");
            this.Property(t => t.IntrntSite).HasColumnName("IntrntSite");
            this.Property(t => t.LangCode).HasColumnName("LangCode");
            this.Property(t => t.HousActKey).HasColumnName("HousActKey");
            this.Property(t => t.Profession).HasColumnName("Profession");
            this.Property(t => t.CDPNum).HasColumnName("CDPNum");
            this.Property(t => t.DflBankKey).HasColumnName("DflBankKey");
            this.Property(t => t.BCACode).HasColumnName("BCACode");
            this.Property(t => t.UseShpdGd).HasColumnName("UseShpdGd");
            this.Property(t => t.RegNum).HasColumnName("RegNum");
            this.Property(t => t.VerifNum).HasColumnName("VerifNum");
            this.Property(t => t.BankCtlKey).HasColumnName("BankCtlKey");
            this.Property(t => t.HousCtlKey).HasColumnName("HousCtlKey");
            this.Property(t => t.AddrType).HasColumnName("AddrType");
            this.Property(t => t.InsurOp347).HasColumnName("InsurOp347");
            this.Property(t => t.MailAddrTy).HasColumnName("MailAddrTy");
            this.Property(t => t.StreetNo).HasColumnName("StreetNo");
            this.Property(t => t.MailStrNo).HasColumnName("MailStrNo");
            this.Property(t => t.TaxRndRule).HasColumnName("TaxRndRule");
            this.Property(t => t.VendTID).HasColumnName("VendTID");
            this.Property(t => t.ThreshOver).HasColumnName("ThreshOver");
            this.Property(t => t.SurOver).HasColumnName("SurOver");
            this.Property(t => t.VendorOcup).HasColumnName("VendorOcup");
            this.Property(t => t.OpCode347).HasColumnName("OpCode347");
            this.Property(t => t.DpmIntAct).HasColumnName("DpmIntAct");
            this.Property(t => t.ResidenNum).HasColumnName("ResidenNum");
            this.Property(t => t.UserSign2).HasColumnName("UserSign2");
            this.Property(t => t.PlngGroup).HasColumnName("PlngGroup");
            this.Property(t => t.VatIDNum).HasColumnName("VatIDNum");
            this.Property(t => t.Affiliate).HasColumnName("Affiliate");
            this.Property(t => t.MivzExpSts).HasColumnName("MivzExpSts");
            this.Property(t => t.HierchDdct).HasColumnName("HierchDdct");
            this.Property(t => t.CertWHT).HasColumnName("CertWHT");
            this.Property(t => t.CertBKeep).HasColumnName("CertBKeep");
            this.Property(t => t.WHShaamGrp).HasColumnName("WHShaamGrp");
            this.Property(t => t.IndustryC).HasColumnName("IndustryC");
            this.Property(t => t.DatevAcct).HasColumnName("DatevAcct");
            this.Property(t => t.DatevFirst).HasColumnName("DatevFirst");
            this.Property(t => t.GTSRegNum).HasColumnName("GTSRegNum");
            this.Property(t => t.GTSBankAct).HasColumnName("GTSBankAct");
            this.Property(t => t.GTSBilAddr).HasColumnName("GTSBilAddr");
            this.Property(t => t.HsBnkSwift).HasColumnName("HsBnkSwift");
            this.Property(t => t.HsBnkIBAN).HasColumnName("HsBnkIBAN");
            this.Property(t => t.DflSwift).HasColumnName("DflSwift");
            this.Property(t => t.AutoPost).HasColumnName("AutoPost");
            this.Property(t => t.IntrAcc).HasColumnName("IntrAcc");
            this.Property(t => t.FeeAcc).HasColumnName("FeeAcc");
            this.Property(t => t.CpnNo).HasColumnName("CpnNo");
            this.Property(t => t.NTSWebSite).HasColumnName("NTSWebSite");
            this.Property(t => t.DflIBAN).HasColumnName("DflIBAN");
            this.Property(t => t.Series).HasColumnName("Series");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.EDocExpFrm).HasColumnName("EDocExpFrm");
            this.Property(t => t.TaxIdIdent).HasColumnName("TaxIdIdent");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.AtcEntry).HasColumnName("AtcEntry");
            this.Property(t => t.DiscRel).HasColumnName("DiscRel");
            this.Property(t => t.NoDiscount).HasColumnName("NoDiscount");
            this.Property(t => t.SCAdjust).HasColumnName("SCAdjust");
            this.Property(t => t.DflAgrmnt).HasColumnName("DflAgrmnt");
            this.Property(t => t.GlblLocNum).HasColumnName("GlblLocNum");
            this.Property(t => t.SenderID).HasColumnName("SenderID");
            this.Property(t => t.RcpntID).HasColumnName("RcpntID");
            this.Property(t => t.MainUsage).HasColumnName("MainUsage");
            this.Property(t => t.SefazCheck).HasColumnName("SefazCheck");
            this.Property(t => t.free312).HasColumnName("free312");
            this.Property(t => t.free313).HasColumnName("free313");
            this.Property(t => t.DateFrom).HasColumnName("DateFrom");
            this.Property(t => t.DateTill).HasColumnName("DateTill");
            this.Property(t => t.RelCode).HasColumnName("RelCode");
            this.Property(t => t.OKATO).HasColumnName("OKATO");
            this.Property(t => t.OKTMO).HasColumnName("OKTMO");
            this.Property(t => t.KBKCode).HasColumnName("KBKCode");
            this.Property(t => t.TypeOfOp).HasColumnName("TypeOfOp");
            this.Property(t => t.OwnerCode).HasColumnName("OwnerCode");
            this.Property(t => t.MandateID).HasColumnName("MandateID");
            this.Property(t => t.SignDate).HasColumnName("SignDate");
            this.Property(t => t.Remark1).HasColumnName("Remark1");
            this.Property(t => t.ConCerti).HasColumnName("ConCerti");
            this.Property(t => t.TpCusPres).HasColumnName("TpCusPres");
            this.Property(t => t.RoleTypCod).HasColumnName("RoleTypCod");
            this.Property(t => t.BlockComm).HasColumnName("BlockComm");
            this.Property(t => t.EmplymntCt).HasColumnName("EmplymntCt");
            this.Property(t => t.ExcptnlEvt).HasColumnName("ExcptnlEvt");
            this.Property(t => t.ExpnPrfFnd).HasColumnName("ExpnPrfFnd");
            this.Property(t => t.EdrsFromBP).HasColumnName("EdrsFromBP");
            this.Property(t => t.EdrsToBP).HasColumnName("EdrsToBP");
            this.Property(t => t.CreateTS).HasColumnName("CreateTS");
            this.Property(t => t.UpdateTS).HasColumnName("UpdateTS");
            this.Property(t => t.EDocGenTyp).HasColumnName("EDocGenTyp");
        }
    }
}
