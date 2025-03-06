using JWDIACONTRACTS.DTO.GeoSurveyDTO;
using JWDIADATA.Data.Entities;



namespace JWDIACONTRACTS.Mappings.GEoSurvey;

public class GeoSurveyMappings
{
    public GeoSurveyMappings(){
        
    }

    public static GeochemSurvey GeoChemConverter(GeochemSurveyDataModel a)
    {
        var b = new GeochemSurvey();

            b.SampleID = a.SampleID;
            b.Gswano = a.GSWANO;
            b.ExtractionDate = a.Extraction_Date;
            b.BatchNo = a.Batch_No;
            b.QmapId = a.QMAPID;
            b.DLat = a.DLat;
            b.DLong = a.DLong;
            b.Easting = a.EASTING;
            b.Northing = a.NORTHING;
            b.Reliability = a.RELIABILITY;
            b.SampleType = a.SAMPLETYPE;
            b.Lithname = a.LITHNAME;
            b.Sitend = a.SITENO;
            b.SiteId = a.SITEID;
            b.OrigNme = a.ORIGNAME;
            b.AgPpm = a.Ag_ppm;
            b.AlPpm = a.Al_ppm;
            b.ArsPpm = a.Ars_ppm;
            b.AuPpm = a.Au_ppm;
            b.BPpm = a.B_ppm;
            b.BaPpm = a.Ba_ppm;
            b.BePpm = a.Be_ppm;
            b.BiPpm = a.Bi_ppm;
            b.CPpm = a.C_ppm;
            b.CaPpm = a.Ca_ppm;
            b.CdPpm = a.Cd_ppm;
            b.CePpm = a.Ce_ppm;
            b.ClPpm = a.Cl_ppm;
            b.CoPpm = a.Co_ppm;
            b.CrPpm = a.Cr_ppm;
            b.CsPpm = a.Cs_ppm;
            b.CuPpm = a.Cu_ppm;
            b.DyPpm = a.Dy_ppm;
            b.ErPpm = a.Er_ppm;
            b.EuPpm = a.Eu_ppm;
            b.FPpm = a.F_ppm;
            b.FePpm = a.Fe_ppm;
            b.GaPpm = a.Ga_ppm;
            b.GdPpm = a.Gd_ppm;
            b.GePpm = a.Ge_ppm;
            b.HfPpm = a.Hf_ppm;
            b.HgPpm = a.Hg_ppm;
            b.HoPpm = a.Ho_ppm;
            b.IndPpm = a.Ind_ppm;
            b.KPpm = a.K_ppm;
            b.LaPpm = a.La_ppm;
            b.LABnegNR_NONE = a.LABnegNR_NONE;
            b.LiPpm = a.Li_ppm;
            b.LuPpm = a.Lu_ppm;
            b.MgPpm = a.Mg_ppm;
            b.MnPpm = a.Mn_ppm;
            b.MoPpm = a.Mo_ppm;
            b.NbPpm = a.Nb_ppm;
            b.NdPpm = a.Nd_ppm;
            b.NiPpm = a.Ni_ppm;
            b.PPpm = a.P_ppm;
            b.PbPpm = a.Pb_ppm;
            b.PrPpm = a.Pr_ppm;
            b.RbPpm = a.Rb_ppm;
            b.SbPpm = a.Sb_ppm;
            b.ScPpm = a.Sc_ppm;
            b.SePpm = a.Se_ppm;
            b.SiPpm = a.Si_ppm;
            b.SmPpm = a.Sm_ppm;
            b.SnPpm = a.Sn_ppm;
            b.SrPpm = a.Sr_ppm;
            b.TaPpm = a.Ta_ppm;
            b.TbPpm = a.Tb_ppm;
            b.TePpm = a.Te_ppm;
            b.ThPpm = a.Th_ppm;
            b.TiPpm = a.Ti_ppm;
            b.TlPpm = a.Tl_ppm;
            b.TmPpm = a.Tm_ppm;
            b.UPpm = a.U_ppm;
            b.VPpm = a.V_ppm;
            b.WPpm = a.W_ppm;
            b.YPpm = a.Y_ppm;
            b.YbPpm = a.Yb_ppm;
            b.ZnPpm = a.Zn_ppm;
            b.ZrPpm = a.Zr_ppm;
            b.AgPpmPct = a.Ag_ppm_pct;
            b.AlPpmPct = a.Al_ppm_pct;
            b.ArsPpmPct = a.Ars_ppm_pct;
            b.AuPpmPct = a.Au_ppm_pct;
            b.BPpmPct = a.B_ppm_pct;
            b.BaPpmPct = a.Ba_ppm_pct;
            b.BePpmPct = a.Be_ppm_pct;
            b.BiPpmPct = a.Bi_ppm_pct;
            b.CPpmPct = a.C_ppm_pct;
            b.CaPpmPct = a.Ca_ppm_pct;
            b.CdPpmPct = a.Cd_ppm_pct;
            b.CePpmPct = a.Ce_ppm_pct;
            b.ClPpmPct = a.Cl_ppm_pct;
            b.CoPpmPct = a.Co_ppm_pct;
            b.CrPpmPct = a.Cr_ppm_pct;
            b.CsPpmPct = a.Cs_ppm_pct;
            b.CuPpmPct = a.Cu_ppm_pct;
            b.DyPpmPct = a.Dy_ppm_pct;
            b.ErPpmPct = a.Er_ppm_pct;
            b.EuPpmPct = a.Eu_ppm_pct;
            b.FPpmPct = a.F_ppm_pct;
            b.FePpmPct = a.Fe_ppm_pct;
            b.GaPpmPct = a.Ga_ppm_pct;
            b.GdPpmPct = a.Gd_ppm_pct;
            b.GePpmPct = a.Ge_ppm_pct;
            b.HfPpmPct = a.Hf_ppm_pct;
            b.HgPpmPct = a.Hg_ppm_pct;
            b.HoPpmPct = a.Ho_ppm_pct;
            b.IndPpmPct = a.Ind_ppm_pct;
            b.KPpmPct = a.K_ppm_pct;
            b.LaPpmPct = a.La_ppm_pct;
            b.LiPpmPct = a.Li_ppm_pct;
            b.LuPpmPct = a.Lu_ppm_pct;
            b.MgPpmPct = a.Mg_ppm_pct;
            b.MnPpmPct = a.Mn_ppm_pct;
            b.MoPpmPct = a.Mo_ppm_pct;
            b.NbPpmPct = a.Nb_ppm_pct;
            b.NdPpmPct = a.Nd_ppm_pct;
            b.NiPpmPct = a.Ni_ppm_pct;
            b.PPpmPct = a.P_ppm_pct;
            b.PbPpmPct = a.Pb_ppm_pct;
            b.PrPpmPct = a.Pr_ppm_pct;
            b.RbPpmPct = a.Rb_ppm_pct;
            b.SbPpmPct = a.Sb_ppm_pct;
            b.ScPpmPct = a.Sc_ppm_pct;
            b.SePpmPct = a.Se_ppm_pct;
            b.SiPpmPct = a.Si_ppm_pct;
            b.SmPpmPct = a.Sm_ppm_pct;
            b.SnPpmPct = a.Sn_ppm_pct;
            b.SrPpmPct = a.Sr_ppm_pct;
            b.TaPpmPct = a.Ta_ppm_pct;
            b.TbPpmPct = a.Tb_ppm_pct;
            b.TePpmPct = a.Te_ppm_pct;
            b.ThPpmPct = a.Th_ppm_pct;
            b.TiPpmPct = a.Ti_ppm_pct;
            b.TlPpmPct = a.Tl_ppm_pct;
            b.TmPpmPct = a.Tm_ppm_pct;
            b.UPpmPct = a.U_ppm_pct;
            b.VPpmPct = a.V_ppm_pct;
            b.WPpmPct = a.W_ppm_pct;
            b.YPpmPct = a.Y_ppm_pct;
            b.YbPpmPct = a.Yb_ppm_pct;
            b.ZnPpmPct = a.Zn_ppm_pct;
            b.ZrPpmPct = a.Zr_ppm_pct;
            b.TopElement = a.Top_1_Elements;
            b.ElementsOver10 = a.Elements_over_10;
            b.allPresentElements = a.all_present_elements;

        return b;
    }



    
}
