using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NHPApi.Models.Mapping
{
    public class OITMMap : EntityTypeConfiguration<OITM>
    {
        public OITMMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemCode);

            // Properties
            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(100);

            this.Property(t => t.FrgnName)
                .HasMaxLength(100);

            this.Property(t => t.VatGourpSa)
                .HasMaxLength(8);

            this.Property(t => t.CodeBars)
                .HasMaxLength(254);

            this.Property(t => t.VATLiable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PrchseItem)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SellItem)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.InvntItem)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IncomeAcct)
                .HasMaxLength(15);

            this.Property(t => t.ExmptIncom)
                .HasMaxLength(15);

            this.Property(t => t.DfltWH)
                .HasMaxLength(8);

            this.Property(t => t.CardCode)
                .HasMaxLength(15);

            this.Property(t => t.SuppCatNum)
                .HasMaxLength(50);

            this.Property(t => t.BuyUnitMsr)
                .HasMaxLength(100);

            this.Property(t => t.Canceled)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WholSlsTax)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RetilrTax)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TrackSales)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SalUnitMsr)
                .HasMaxLength(100);

            this.Property(t => t.EvalSystem)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FREE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PicturName)
                .HasMaxLength(200);

            this.Property(t => t.Transfered)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BlncTrnsfr)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SerialNum)
                .HasMaxLength(17);

            this.Property(t => t.TreeType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LastPurCur)
                .HasMaxLength(3);

            this.Property(t => t.ExitCur)
                .HasMaxLength(3);

            this.Property(t => t.ExitWH)
                .HasMaxLength(8);

            this.Property(t => t.AssetItem)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WasCounted)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ManSerNum)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FixCurrCms)
                .HasMaxLength(3);

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

            this.Property(t => t.ExportCode)
                .HasMaxLength(20);

            this.Property(t => t.SalFormula)
                .HasMaxLength(40);

            this.Property(t => t.PurFormula)
                .HasMaxLength(40);

            this.Property(t => t.VatGroupPu)
                .HasMaxLength(8);

            this.Property(t => t.PurPackMsr)
                .HasMaxLength(30);

            this.Property(t => t.SalPackMsr)
                .HasMaxLength(30);

            this.Property(t => t.ManBtchNum)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ManOutOnly)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DataSource)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.validFor)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.frozenFor)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BlockOut)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ValidComm)
                .HasMaxLength(30);

            this.Property(t => t.FrozenComm)
                .HasMaxLength(30);

            this.Property(t => t.ObjType)
                .HasMaxLength(20);

            this.Property(t => t.SWW)
                .HasMaxLength(16);

            this.Property(t => t.Deleted)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ExpensAcct)
                .HasMaxLength(15);

            this.Property(t => t.FrgnInAcct)
                .HasMaxLength(15);

            this.Property(t => t.GLMethod)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ECInAcct)
                .HasMaxLength(15);

            this.Property(t => t.FrgnExpAcc)
                .HasMaxLength(15);

            this.Property(t => t.ECExpAcc)
                .HasMaxLength(15);

            this.Property(t => t.TaxType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ByWh)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WTLiable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ItemType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WarrntTmpl)
                .HasMaxLength(20);

            this.Property(t => t.BaseUnit)
                .HasMaxLength(20);

            this.Property(t => t.CountryOrg)
                .HasMaxLength(3);

            this.Property(t => t.Phantom)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IssueMthd)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FREE1)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MngMethod)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.InvntryUom)
                .HasMaxLength(100);

            this.Property(t => t.PlaningSys)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PrcrmntMtd)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IndirctTax)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TaxCodeAR)
                .HasMaxLength(8);

            this.Property(t => t.TaxCodeAP)
                .HasMaxLength(8);

            this.Property(t => t.MatType)
                .HasMaxLength(3);

            this.Property(t => t.ProductSrc)
                .HasMaxLength(2);

            this.Property(t => t.ItemClass)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Excisable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NotifyASN)
                .HasMaxLength(40);

            this.Property(t => t.ProAssNum)
                .HasMaxLength(20);

            this.Property(t => t.Spec)
                .HasMaxLength(30);

            this.Property(t => t.TaxCtg)
                .HasMaxLength(4);

            this.Property(t => t.BeverTblC)
                .HasMaxLength(2);

            this.Property(t => t.BeverGrpC)
                .HasMaxLength(2);

            this.Property(t => t.AssetClass)
                .HasMaxLength(20);

            this.Property(t => t.AssetGroup)
                .HasMaxLength(15);

            this.Property(t => t.InventryNo)
                .HasMaxLength(12);

            this.Property(t => t.StatAsset)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Cession)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DeacAftUL)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AsstStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GLPickMeth)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NoDiscount)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MgrByQty)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AssetRmk1)
                .HasMaxLength(100);

            this.Property(t => t.AssetRmk2)
                .HasMaxLength(100);

            this.Property(t => t.DeprGroup)
                .HasMaxLength(15);

            this.Property(t => t.AssetSerNo)
                .HasMaxLength(32);

            this.Property(t => t.CntUnitMsr)
                .HasMaxLength(100);

            this.Property(t => t.OneBOneRec)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RuleCode)
                .HasMaxLength(2);

            this.Property(t => t.ScsCode)
                .HasMaxLength(10);

            this.Property(t => t.SpProdType)
                .HasMaxLength(2);

            this.Property(t => t.CompoWH)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VirtAstItm)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SouVirAsst)
                .HasMaxLength(50);

            this.Property(t => t.InCostRoll)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EnAstSeri)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.U_SubGroup)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OITM");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.FrgnName).HasColumnName("FrgnName");
            this.Property(t => t.ItmsGrpCod).HasColumnName("ItmsGrpCod");
            this.Property(t => t.CstGrpCode).HasColumnName("CstGrpCode");
            this.Property(t => t.VatGourpSa).HasColumnName("VatGourpSa");
            this.Property(t => t.CodeBars).HasColumnName("CodeBars");
            this.Property(t => t.VATLiable).HasColumnName("VATLiable");
            this.Property(t => t.PrchseItem).HasColumnName("PrchseItem");
            this.Property(t => t.SellItem).HasColumnName("SellItem");
            this.Property(t => t.InvntItem).HasColumnName("InvntItem");
            this.Property(t => t.OnHand).HasColumnName("OnHand");
            this.Property(t => t.IsCommited).HasColumnName("IsCommited");
            this.Property(t => t.OnOrder).HasColumnName("OnOrder");
            this.Property(t => t.IncomeAcct).HasColumnName("IncomeAcct");
            this.Property(t => t.ExmptIncom).HasColumnName("ExmptIncom");
            this.Property(t => t.MaxLevel).HasColumnName("MaxLevel");
            this.Property(t => t.DfltWH).HasColumnName("DfltWH");
            this.Property(t => t.CardCode).HasColumnName("CardCode");
            this.Property(t => t.SuppCatNum).HasColumnName("SuppCatNum");
            this.Property(t => t.BuyUnitMsr).HasColumnName("BuyUnitMsr");
            this.Property(t => t.NumInBuy).HasColumnName("NumInBuy");
            this.Property(t => t.ReorderQty).HasColumnName("ReorderQty");
            this.Property(t => t.MinLevel).HasColumnName("MinLevel");
            this.Property(t => t.LstEvlPric).HasColumnName("LstEvlPric");
            this.Property(t => t.LstEvlDate).HasColumnName("LstEvlDate");
            this.Property(t => t.CustomPer).HasColumnName("CustomPer");
            this.Property(t => t.Canceled).HasColumnName("Canceled");
            this.Property(t => t.MnufctTime).HasColumnName("MnufctTime");
            this.Property(t => t.WholSlsTax).HasColumnName("WholSlsTax");
            this.Property(t => t.RetilrTax).HasColumnName("RetilrTax");
            this.Property(t => t.SpcialDisc).HasColumnName("SpcialDisc");
            this.Property(t => t.DscountCod).HasColumnName("DscountCod");
            this.Property(t => t.TrackSales).HasColumnName("TrackSales");
            this.Property(t => t.SalUnitMsr).HasColumnName("SalUnitMsr");
            this.Property(t => t.NumInSale).HasColumnName("NumInSale");
            this.Property(t => t.Consig).HasColumnName("Consig");
            this.Property(t => t.QueryGroup).HasColumnName("QueryGroup");
            this.Property(t => t.Counted).HasColumnName("Counted");
            this.Property(t => t.OpenBlnc).HasColumnName("OpenBlnc");
            this.Property(t => t.EvalSystem).HasColumnName("EvalSystem");
            this.Property(t => t.UserSign).HasColumnName("UserSign");
            this.Property(t => t.FREE).HasColumnName("FREE");
            this.Property(t => t.PicturName).HasColumnName("PicturName");
            this.Property(t => t.Transfered).HasColumnName("Transfered");
            this.Property(t => t.BlncTrnsfr).HasColumnName("BlncTrnsfr");
            this.Property(t => t.UserText).HasColumnName("UserText");
            this.Property(t => t.SerialNum).HasColumnName("SerialNum");
            this.Property(t => t.CommisPcnt).HasColumnName("CommisPcnt");
            this.Property(t => t.CommisSum).HasColumnName("CommisSum");
            this.Property(t => t.CommisGrp).HasColumnName("CommisGrp");
            this.Property(t => t.TreeType).HasColumnName("TreeType");
            this.Property(t => t.TreeQty).HasColumnName("TreeQty");
            this.Property(t => t.LastPurPrc).HasColumnName("LastPurPrc");
            this.Property(t => t.LastPurCur).HasColumnName("LastPurCur");
            this.Property(t => t.LastPurDat).HasColumnName("LastPurDat");
            this.Property(t => t.ExitCur).HasColumnName("ExitCur");
            this.Property(t => t.ExitPrice).HasColumnName("ExitPrice");
            this.Property(t => t.ExitWH).HasColumnName("ExitWH");
            this.Property(t => t.AssetItem).HasColumnName("AssetItem");
            this.Property(t => t.WasCounted).HasColumnName("WasCounted");
            this.Property(t => t.ManSerNum).HasColumnName("ManSerNum");
            this.Property(t => t.SHeight1).HasColumnName("SHeight1");
            this.Property(t => t.SHght1Unit).HasColumnName("SHght1Unit");
            this.Property(t => t.SHeight2).HasColumnName("SHeight2");
            this.Property(t => t.SHght2Unit).HasColumnName("SHght2Unit");
            this.Property(t => t.SWidth1).HasColumnName("SWidth1");
            this.Property(t => t.SWdth1Unit).HasColumnName("SWdth1Unit");
            this.Property(t => t.SWidth2).HasColumnName("SWidth2");
            this.Property(t => t.SWdth2Unit).HasColumnName("SWdth2Unit");
            this.Property(t => t.SLength1).HasColumnName("SLength1");
            this.Property(t => t.SLen1Unit).HasColumnName("SLen1Unit");
            this.Property(t => t.Slength2).HasColumnName("Slength2");
            this.Property(t => t.SLen2Unit).HasColumnName("SLen2Unit");
            this.Property(t => t.SVolume).HasColumnName("SVolume");
            this.Property(t => t.SVolUnit).HasColumnName("SVolUnit");
            this.Property(t => t.SWeight1).HasColumnName("SWeight1");
            this.Property(t => t.SWght1Unit).HasColumnName("SWght1Unit");
            this.Property(t => t.SWeight2).HasColumnName("SWeight2");
            this.Property(t => t.SWght2Unit).HasColumnName("SWght2Unit");
            this.Property(t => t.BHeight1).HasColumnName("BHeight1");
            this.Property(t => t.BHght1Unit).HasColumnName("BHght1Unit");
            this.Property(t => t.BHeight2).HasColumnName("BHeight2");
            this.Property(t => t.BHght2Unit).HasColumnName("BHght2Unit");
            this.Property(t => t.BWidth1).HasColumnName("BWidth1");
            this.Property(t => t.BWdth1Unit).HasColumnName("BWdth1Unit");
            this.Property(t => t.BWidth2).HasColumnName("BWidth2");
            this.Property(t => t.BWdth2Unit).HasColumnName("BWdth2Unit");
            this.Property(t => t.BLength1).HasColumnName("BLength1");
            this.Property(t => t.BLen1Unit).HasColumnName("BLen1Unit");
            this.Property(t => t.Blength2).HasColumnName("Blength2");
            this.Property(t => t.BLen2Unit).HasColumnName("BLen2Unit");
            this.Property(t => t.BVolume).HasColumnName("BVolume");
            this.Property(t => t.BVolUnit).HasColumnName("BVolUnit");
            this.Property(t => t.BWeight1).HasColumnName("BWeight1");
            this.Property(t => t.BWght1Unit).HasColumnName("BWght1Unit");
            this.Property(t => t.BWeight2).HasColumnName("BWeight2");
            this.Property(t => t.BWght2Unit).HasColumnName("BWght2Unit");
            this.Property(t => t.FixCurrCms).HasColumnName("FixCurrCms");
            this.Property(t => t.FirmCode).HasColumnName("FirmCode");
            this.Property(t => t.LstSalDate).HasColumnName("LstSalDate");
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
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.ExportCode).HasColumnName("ExportCode");
            this.Property(t => t.SalFactor1).HasColumnName("SalFactor1");
            this.Property(t => t.SalFactor2).HasColumnName("SalFactor2");
            this.Property(t => t.SalFactor3).HasColumnName("SalFactor3");
            this.Property(t => t.SalFactor4).HasColumnName("SalFactor4");
            this.Property(t => t.PurFactor1).HasColumnName("PurFactor1");
            this.Property(t => t.PurFactor2).HasColumnName("PurFactor2");
            this.Property(t => t.PurFactor3).HasColumnName("PurFactor3");
            this.Property(t => t.PurFactor4).HasColumnName("PurFactor4");
            this.Property(t => t.SalFormula).HasColumnName("SalFormula");
            this.Property(t => t.PurFormula).HasColumnName("PurFormula");
            this.Property(t => t.VatGroupPu).HasColumnName("VatGroupPu");
            this.Property(t => t.AvgPrice).HasColumnName("AvgPrice");
            this.Property(t => t.PurPackMsr).HasColumnName("PurPackMsr");
            this.Property(t => t.PurPackUn).HasColumnName("PurPackUn");
            this.Property(t => t.SalPackMsr).HasColumnName("SalPackMsr");
            this.Property(t => t.SalPackUn).HasColumnName("SalPackUn");
            this.Property(t => t.SCNCounter).HasColumnName("SCNCounter");
            this.Property(t => t.ManBtchNum).HasColumnName("ManBtchNum");
            this.Property(t => t.ManOutOnly).HasColumnName("ManOutOnly");
            this.Property(t => t.DataSource).HasColumnName("DataSource");
            this.Property(t => t.validFor).HasColumnName("validFor");
            this.Property(t => t.validFrom).HasColumnName("validFrom");
            this.Property(t => t.validTo).HasColumnName("validTo");
            this.Property(t => t.frozenFor).HasColumnName("frozenFor");
            this.Property(t => t.frozenFrom).HasColumnName("frozenFrom");
            this.Property(t => t.frozenTo).HasColumnName("frozenTo");
            this.Property(t => t.BlockOut).HasColumnName("BlockOut");
            this.Property(t => t.ValidComm).HasColumnName("ValidComm");
            this.Property(t => t.FrozenComm).HasColumnName("FrozenComm");
            this.Property(t => t.LogInstanc).HasColumnName("LogInstanc");
            this.Property(t => t.ObjType).HasColumnName("ObjType");
            this.Property(t => t.SWW).HasColumnName("SWW");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.DocEntry).HasColumnName("DocEntry");
            this.Property(t => t.ExpensAcct).HasColumnName("ExpensAcct");
            this.Property(t => t.FrgnInAcct).HasColumnName("FrgnInAcct");
            this.Property(t => t.ShipType).HasColumnName("ShipType");
            this.Property(t => t.GLMethod).HasColumnName("GLMethod");
            this.Property(t => t.ECInAcct).HasColumnName("ECInAcct");
            this.Property(t => t.FrgnExpAcc).HasColumnName("FrgnExpAcc");
            this.Property(t => t.ECExpAcc).HasColumnName("ECExpAcc");
            this.Property(t => t.TaxType).HasColumnName("TaxType");
            this.Property(t => t.ByWh).HasColumnName("ByWh");
            this.Property(t => t.WTLiable).HasColumnName("WTLiable");
            this.Property(t => t.ItemType).HasColumnName("ItemType");
            this.Property(t => t.WarrntTmpl).HasColumnName("WarrntTmpl");
            this.Property(t => t.BaseUnit).HasColumnName("BaseUnit");
            this.Property(t => t.CountryOrg).HasColumnName("CountryOrg");
            this.Property(t => t.StockValue).HasColumnName("StockValue");
            this.Property(t => t.Phantom).HasColumnName("Phantom");
            this.Property(t => t.IssueMthd).HasColumnName("IssueMthd");
            this.Property(t => t.FREE1).HasColumnName("FREE1");
            this.Property(t => t.PricingPrc).HasColumnName("PricingPrc");
            this.Property(t => t.MngMethod).HasColumnName("MngMethod");
            this.Property(t => t.ReorderPnt).HasColumnName("ReorderPnt");
            this.Property(t => t.InvntryUom).HasColumnName("InvntryUom");
            this.Property(t => t.PlaningSys).HasColumnName("PlaningSys");
            this.Property(t => t.PrcrmntMtd).HasColumnName("PrcrmntMtd");
            this.Property(t => t.OrdrIntrvl).HasColumnName("OrdrIntrvl");
            this.Property(t => t.OrdrMulti).HasColumnName("OrdrMulti");
            this.Property(t => t.MinOrdrQty).HasColumnName("MinOrdrQty");
            this.Property(t => t.LeadTime).HasColumnName("LeadTime");
            this.Property(t => t.IndirctTax).HasColumnName("IndirctTax");
            this.Property(t => t.TaxCodeAR).HasColumnName("TaxCodeAR");
            this.Property(t => t.TaxCodeAP).HasColumnName("TaxCodeAP");
            this.Property(t => t.OSvcCode).HasColumnName("OSvcCode");
            this.Property(t => t.ISvcCode).HasColumnName("ISvcCode");
            this.Property(t => t.ServiceGrp).HasColumnName("ServiceGrp");
            this.Property(t => t.NCMCode).HasColumnName("NCMCode");
            this.Property(t => t.MatType).HasColumnName("MatType");
            this.Property(t => t.MatGrp).HasColumnName("MatGrp");
            this.Property(t => t.ProductSrc).HasColumnName("ProductSrc");
            this.Property(t => t.ServiceCtg).HasColumnName("ServiceCtg");
            this.Property(t => t.ItemClass).HasColumnName("ItemClass");
            this.Property(t => t.Excisable).HasColumnName("Excisable");
            this.Property(t => t.ChapterID).HasColumnName("ChapterID");
            this.Property(t => t.NotifyASN).HasColumnName("NotifyASN");
            this.Property(t => t.ProAssNum).HasColumnName("ProAssNum");
            this.Property(t => t.AssblValue).HasColumnName("AssblValue");
            this.Property(t => t.DNFEntry).HasColumnName("DNFEntry");
            this.Property(t => t.UserSign2).HasColumnName("UserSign2");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.TaxCtg).HasColumnName("TaxCtg");
            this.Property(t => t.Series).HasColumnName("Series");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.FuelCode).HasColumnName("FuelCode");
            this.Property(t => t.BeverTblC).HasColumnName("BeverTblC");
            this.Property(t => t.BeverGrpC).HasColumnName("BeverGrpC");
            this.Property(t => t.BeverTM).HasColumnName("BeverTM");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.AtcEntry).HasColumnName("AtcEntry");
            this.Property(t => t.ToleranDay).HasColumnName("ToleranDay");
            this.Property(t => t.UgpEntry).HasColumnName("UgpEntry");
            this.Property(t => t.PUoMEntry).HasColumnName("PUoMEntry");
            this.Property(t => t.SUoMEntry).HasColumnName("SUoMEntry");
            this.Property(t => t.IUoMEntry).HasColumnName("IUoMEntry");
            this.Property(t => t.IssuePriBy).HasColumnName("IssuePriBy");
            this.Property(t => t.AssetClass).HasColumnName("AssetClass");
            this.Property(t => t.AssetGroup).HasColumnName("AssetGroup");
            this.Property(t => t.InventryNo).HasColumnName("InventryNo");
            this.Property(t => t.Technician).HasColumnName("Technician");
            this.Property(t => t.Employee).HasColumnName("Employee");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.StatAsset).HasColumnName("StatAsset");
            this.Property(t => t.Cession).HasColumnName("Cession");
            this.Property(t => t.DeacAftUL).HasColumnName("DeacAftUL");
            this.Property(t => t.AsstStatus).HasColumnName("AsstStatus");
            this.Property(t => t.CapDate).HasColumnName("CapDate");
            this.Property(t => t.AcqDate).HasColumnName("AcqDate");
            this.Property(t => t.RetDate).HasColumnName("RetDate");
            this.Property(t => t.GLPickMeth).HasColumnName("GLPickMeth");
            this.Property(t => t.NoDiscount).HasColumnName("NoDiscount");
            this.Property(t => t.MgrByQty).HasColumnName("MgrByQty");
            this.Property(t => t.AssetRmk1).HasColumnName("AssetRmk1");
            this.Property(t => t.AssetRmk2).HasColumnName("AssetRmk2");
            this.Property(t => t.AssetAmnt1).HasColumnName("AssetAmnt1");
            this.Property(t => t.AssetAmnt2).HasColumnName("AssetAmnt2");
            this.Property(t => t.DeprGroup).HasColumnName("DeprGroup");
            this.Property(t => t.AssetSerNo).HasColumnName("AssetSerNo");
            this.Property(t => t.CntUnitMsr).HasColumnName("CntUnitMsr");
            this.Property(t => t.NumInCnt).HasColumnName("NumInCnt");
            this.Property(t => t.INUoMEntry).HasColumnName("INUoMEntry");
            this.Property(t => t.OneBOneRec).HasColumnName("OneBOneRec");
            this.Property(t => t.RuleCode).HasColumnName("RuleCode");
            this.Property(t => t.ScsCode).HasColumnName("ScsCode");
            this.Property(t => t.SpProdType).HasColumnName("SpProdType");
            this.Property(t => t.IWeight1).HasColumnName("IWeight1");
            this.Property(t => t.IWght1Unit).HasColumnName("IWght1Unit");
            this.Property(t => t.IWeight2).HasColumnName("IWeight2");
            this.Property(t => t.IWght2Unit).HasColumnName("IWght2Unit");
            this.Property(t => t.CompoWH).HasColumnName("CompoWH");
            this.Property(t => t.CreateTS).HasColumnName("CreateTS");
            this.Property(t => t.UpdateTS).HasColumnName("UpdateTS");
            this.Property(t => t.VirtAstItm).HasColumnName("VirtAstItm");
            this.Property(t => t.SouVirAsst).HasColumnName("SouVirAsst");
            this.Property(t => t.InCostRoll).HasColumnName("InCostRoll");
            this.Property(t => t.PrdStdCst).HasColumnName("PrdStdCst");
            this.Property(t => t.EnAstSeri).HasColumnName("EnAstSeri");
            this.Property(t => t.U_SubGroup).HasColumnName("U_SubGroup");
        }
    }
}
