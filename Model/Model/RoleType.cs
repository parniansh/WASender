using System.ComponentModel.DataAnnotations;

namespace Model.Model
{
    public enum RoleType : byte
    {
        [Display(Name = "برنامه‌نویس")]
        Developer = 1,

        [Display(Name = "سوپر ادمین")]
        SuperAdmin = 2,

        [Display(Name = "نمایندگی")]
        Agency = 4,

        [Display(Name = "بازاریاب")]
        Marketer = 8,

        [Display(Name = "مدیریت فودکورت")]
        FoodCourt = 16,

        [Display(Name = "رستوران")]
        Restaurant = 32
    }
}
