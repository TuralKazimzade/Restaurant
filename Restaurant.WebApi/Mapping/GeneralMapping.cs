using AutoMapper;
using AutoMapper.Features;
using Restaurant.WebApi.Dtos.FeatureDtos;
using Restaurant.WebApi.Dtos.MessageDtos;
using Restaurant.WebApi.Dtos.NotificationDtos;
using Restaurant.WebApi.Dtos.ProductDtos;
using Restaurant.WebApi.Entities;

namespace Restaurant.WebApi.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();

            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductWithCategoryDto>().ForMember(x=>x.CategoryName, y=>y.MapFrom(z=>z.Category.CategoryName)).ReverseMap();

            CreateMap<Notification,ResultNotificationDto>().ReverseMap();
            CreateMap<Notification,CreateNotificationDto>().ReverseMap();
            CreateMap<Notification,UpdateNotificationDto>().ReverseMap();
            CreateMap<Notification,GetByIdNotificationDto>().ReverseMap();
        }
    }
}
