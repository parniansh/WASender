using System.ComponentModel.DataAnnotations;


namespace Model.Model
{
    public enum CollaborationType : byte
    {


        [Display(Name = "شاپی")]
        Shopeee = 1,

        [Display(Name = "نمایندگی")]
        Agency = 2,

        [Display(Name = "تمام الکترونیک")]
        Tamam = 3,

        [Display(Name = " همکاری")]
        Cooperation = 4,

        [Display(Name = "سایر")]
        Other = 5,

    }
}
