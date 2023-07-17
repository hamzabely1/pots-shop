using Api.Data.Context.Model;


namespace Api.Business.Service.Mapper
{
    public class MapperItemCharacteristic
    {
        public static Color TransformIdColor(Color color)
        {
            return new Color()
            {
                Label = color.Label
            };
        }
        public static Material TransformIdMaterial(Material material)
        {
            return new Material()
            {
                Label = material.Label
            };
        }
        public static Category TransformIdCategory(Category category)
        {
            return new Category()
            {
                Label = category.Label
            };
        }


    }
}
