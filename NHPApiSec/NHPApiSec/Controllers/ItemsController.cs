using System.Linq;
using System.Collections.Generic;
using NHPApi.Models;
using System.Web.Http.Results;
using System.Web.Http;
using NHPApi.ViewModels;
using AutoMapper;

namespace SAPAPI.Controllers
{
    [Authorize]
    [System.Web.Mvc.Route("api/[controller]")]
    public class ItemsController : BaseController
    {
        [HttpGet]
        public IEnumerable<ProductVm> Get()
        {
            using (var context = new SAPAPIContext())
            {
                var ocrds = context.OITMs.SqlQuery(@"SELECT     a.ItemCode, a.ItemName, FrgnName, ItmsGrpCod, CstGrpCode, VatGourpSa, CodeBars, VATLiable, PrchseItem, SellItem, InvntItem, OnHand, IsCommited, OnOrder, 
                      IncomeAcct, ExmptIncom, MaxLevel, DfltWH, CardCode, SuppCatNum, BuyUnitMsr, NumInBuy, ReorderQty, MinLevel, LstEvlPric, LstEvlDate, CustomPer, Canceled, 
                      MnufctTime, WholSlsTax, RetilrTax, SpcialDisc, DscountCod, TrackSales, SalUnitMsr, NumInSale, Consig, QueryGroup, Counted, OpenBlnc, EvalSystem, UserSign, 
                      FREE, PicturName, Transfered, BlncTrnsfr, UserText, SerialNum, CommisPcnt, CommisSum, CommisGrp, TreeType, TreeQty, LastPurPrc, LastPurCur, LastPurDat, 
                      ExitCur, ExitPrice, ExitWH, AssetItem, WasCounted, ManSerNum, SHeight1, SHght1Unit, SHeight2, SHght2Unit, SWidth1, SWdth1Unit, SWidth2, SWdth2Unit, 
                      SLength1, SLen1Unit, Slength2, SLen2Unit, SVolume, SVolUnit, SWeight1, SWght1Unit, SWeight2, SWght2Unit, BHeight1, BHght1Unit, BHeight2, BHght2Unit, 
                      BWidth1, BWdth1Unit, BWidth2, BWdth2Unit, BLength1, BLen1Unit, Blength2, BLen2Unit, BVolume, BVolUnit, BWeight1, BWght1Unit, BWeight2, BWght2Unit, 
                      FixCurrCms, FirmCode, LstSalDate, QryGroup1, QryGroup2, QryGroup3, QryGroup4, QryGroup5, QryGroup6, QryGroup7, QryGroup8, QryGroup9, QryGroup10, 
                      QryGroup11, QryGroup12, QryGroup13, QryGroup14, QryGroup15, QryGroup16, QryGroup17, QryGroup18, QryGroup19, QryGroup20, QryGroup21, QryGroup22, 
                      QryGroup23, QryGroup24, QryGroup25, QryGroup26, QryGroup27, QryGroup28, QryGroup29, QryGroup30, QryGroup31, QryGroup32, QryGroup33, QryGroup34, 
                      QryGroup35, QryGroup36, QryGroup37, QryGroup38, QryGroup39, QryGroup40, QryGroup41, QryGroup42, QryGroup43, QryGroup44, QryGroup45, QryGroup46, 
                      QryGroup47, QryGroup48, QryGroup49, QryGroup50, QryGroup51, QryGroup52, QryGroup53, QryGroup54, QryGroup55, QryGroup56, QryGroup57, QryGroup58, 
                      QryGroup59, QryGroup60, QryGroup61, QryGroup62, QryGroup63, QryGroup64, CreateDate, UpdateDate, ExportCode, SalFactor1, SalFactor2, SalFactor3, SalFactor4, 
                      PurFactor1, PurFactor2, PurFactor3, PurFactor4, SalFormula, PurFormula, VatGroupPu, AvgPrice, PurPackMsr, PurPackUn, SalPackMsr, SalPackUn, SCNCounter, 
                      ManBtchNum, ManOutOnly, DataSource, validFor, validFrom, validTo, frozenFor, frozenFrom, frozenTo, BlockOut, ValidComm, FrozenComm, a.LogInstanc, a.ObjType, 
                      SWW, Deleted, DocEntry, ExpensAcct, FrgnInAcct, ShipType, GLMethod, ECInAcct, FrgnExpAcc, ECExpAcc, TaxType, ByWh, WTLiable, ItemType, WarrntTmpl, 
                      BaseUnit, CountryOrg, StockValue, Phantom, IssueMthd, FREE1, MngMethod, ReorderPnt, InvntryUom, PlaningSys, PrcrmntMtd, OrdrIntrvl, OrdrMulti, 
                      MinOrdrQty, LeadTime, IndirctTax, TaxCodeAR, TaxCodeAP, OSvcCode, ISvcCode, ServiceGrp, NCMCode, MatType, MatGrp, ProductSrc, ServiceCtg, ItemClass, 
                      Excisable, ChapterID, NotifyASN, ProAssNum, AssblValue, DNFEntry, UserSign2, Spec, TaxCtg, Series, Number, FuelCode, BeverTblC, BeverGrpC, BeverTM, 
                      Attachment, AtcEntry, ToleranDay, UgpEntry, PUoMEntry, SUoMEntry, IUoMEntry, IssuePriBy, AssetClass, AssetGroup, InventryNo, Technician, Employee, Location, 
                      StatAsset, Cession, DeacAftUL, AsstStatus, CapDate, AcqDate, RetDate, GLPickMeth, NoDiscount, MgrByQty, AssetRmk1, AssetRmk2, AssetAmnt1, AssetAmnt2, 
                      DeprGroup, AssetSerNo, CntUnitMsr, NumInCnt, INUoMEntry, OneBOneRec, RuleCode, ScsCode, SpProdType, IWeight1, IWght1Unit, IWeight2, IWght2Unit, 
                      CompoWH, CreateTS, UpdateTS, VirtAstItm, SouVirAsst, InCostRoll, PrdStdCst, EnAstSeri, U_SubGroup,b.Price PricingPrc
                      FROM         OITM a 
                                                    join itm1 b on a.itemcode = b.itemcode
                                                     where salunitmsr is not NULL and itemtype = 'I' and b.pricelist = 1").ToList();
                var org = Mapper.Map<List<OITM>, List<ProductVm>>(ocrds);
                return org;
            }
        }


        // api/values/5
        [HttpGet]
        public IEnumerable<ProductVm> Get(string itemcode)
        {
            using (var context = new SAPAPIContext())
            {
                var ocrds = context.OITMs.SqlQuery(@"SELECT     a.ItemCode, a.ItemName, FrgnName, ItmsGrpCod, CstGrpCode, VatGourpSa, CodeBars, VATLiable, PrchseItem, SellItem, InvntItem, OnHand, IsCommited, OnOrder, 
                      IncomeAcct, ExmptIncom, MaxLevel, DfltWH, CardCode, SuppCatNum, BuyUnitMsr, NumInBuy, ReorderQty, MinLevel, LstEvlPric, LstEvlDate, CustomPer, Canceled, 
                      MnufctTime, WholSlsTax, RetilrTax, SpcialDisc, DscountCod, TrackSales, SalUnitMsr, NumInSale, Consig, QueryGroup, Counted, OpenBlnc, EvalSystem, UserSign, 
                      FREE, PicturName, Transfered, BlncTrnsfr, UserText, SerialNum, CommisPcnt, CommisSum, CommisGrp, TreeType, TreeQty, LastPurPrc, LastPurCur, LastPurDat, 
                      ExitCur, ExitPrice, ExitWH, AssetItem, WasCounted, ManSerNum, SHeight1, SHght1Unit, SHeight2, SHght2Unit, SWidth1, SWdth1Unit, SWidth2, SWdth2Unit, 
                      SLength1, SLen1Unit, Slength2, SLen2Unit, SVolume, SVolUnit, SWeight1, SWght1Unit, SWeight2, SWght2Unit, BHeight1, BHght1Unit, BHeight2, BHght2Unit, 
                      BWidth1, BWdth1Unit, BWidth2, BWdth2Unit, BLength1, BLen1Unit, Blength2, BLen2Unit, BVolume, BVolUnit, BWeight1, BWght1Unit, BWeight2, BWght2Unit, 
                      FixCurrCms, FirmCode, LstSalDate, QryGroup1, QryGroup2, QryGroup3, QryGroup4, QryGroup5, QryGroup6, QryGroup7, QryGroup8, QryGroup9, QryGroup10, 
                      QryGroup11, QryGroup12, QryGroup13, QryGroup14, QryGroup15, QryGroup16, QryGroup17, QryGroup18, QryGroup19, QryGroup20, QryGroup21, QryGroup22, 
                      QryGroup23, QryGroup24, QryGroup25, QryGroup26, QryGroup27, QryGroup28, QryGroup29, QryGroup30, QryGroup31, QryGroup32, QryGroup33, QryGroup34, 
                      QryGroup35, QryGroup36, QryGroup37, QryGroup38, QryGroup39, QryGroup40, QryGroup41, QryGroup42, QryGroup43, QryGroup44, QryGroup45, QryGroup46, 
                      QryGroup47, QryGroup48, QryGroup49, QryGroup50, QryGroup51, QryGroup52, QryGroup53, QryGroup54, QryGroup55, QryGroup56, QryGroup57, QryGroup58, 
                      QryGroup59, QryGroup60, QryGroup61, QryGroup62, QryGroup63, QryGroup64, CreateDate, UpdateDate, ExportCode, SalFactor1, SalFactor2, SalFactor3, SalFactor4, 
                      PurFactor1, PurFactor2, PurFactor3, PurFactor4, SalFormula, PurFormula, VatGroupPu, AvgPrice, PurPackMsr, PurPackUn, SalPackMsr, SalPackUn, SCNCounter, 
                      ManBtchNum, ManOutOnly, DataSource, validFor, validFrom, validTo, frozenFor, frozenFrom, frozenTo, BlockOut, ValidComm, FrozenComm, a.LogInstanc, a.ObjType, 
                      SWW, Deleted, DocEntry, ExpensAcct, FrgnInAcct, ShipType, GLMethod, ECInAcct, FrgnExpAcc, ECExpAcc, TaxType, ByWh, WTLiable, ItemType, WarrntTmpl, 
                      BaseUnit, CountryOrg, StockValue, Phantom, IssueMthd, FREE1, MngMethod, ReorderPnt, InvntryUom, PlaningSys, PrcrmntMtd, OrdrIntrvl, OrdrMulti, 
                      MinOrdrQty, LeadTime, IndirctTax, TaxCodeAR, TaxCodeAP, OSvcCode, ISvcCode, ServiceGrp, NCMCode, MatType, MatGrp, ProductSrc, ServiceCtg, ItemClass, 
                      Excisable, ChapterID, NotifyASN, ProAssNum, AssblValue, DNFEntry, UserSign2, Spec, TaxCtg, Series, Number, FuelCode, BeverTblC, BeverGrpC, BeverTM, 
                      Attachment, AtcEntry, ToleranDay, UgpEntry, PUoMEntry, SUoMEntry, IUoMEntry, IssuePriBy, AssetClass, AssetGroup, InventryNo, Technician, Employee, Location, 
                      StatAsset, Cession, DeacAftUL, AsstStatus, CapDate, AcqDate, RetDate, GLPickMeth, NoDiscount, MgrByQty, AssetRmk1, AssetRmk2, AssetAmnt1, AssetAmnt2, 
                      DeprGroup, AssetSerNo, CntUnitMsr, NumInCnt, INUoMEntry, OneBOneRec, RuleCode, ScsCode, SpProdType, IWeight1, IWght1Unit, IWeight2, IWght2Unit, 
                      CompoWH, CreateTS, UpdateTS, VirtAstItm, SouVirAsst, InCostRoll, PrdStdCst, EnAstSeri, U_SubGroup,b.Price PricingPrc
                      FROM         OITM a  
                                                    join itm1 b on a.itemcode = b.itemcodewhere salunitmsr is not NULL and itemtype = 'I'  AND b.pricelist = 1 AND ItemCode = '" + itemcode + "'").ToList();
                var org = Mapper.Map<List<OITM>, List<ProductVm>>(ocrds);
                return org;
            }
        }




    }
}