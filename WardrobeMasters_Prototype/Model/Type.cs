namespace WardrobeMasters_Prototype.Model
{
    public class Type : Base
    {
        public GenderEnum Gender { get; set; }
    }

    public enum GenderEnum
    {
        Male,
        Female
    }
}
