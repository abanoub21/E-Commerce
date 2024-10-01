using AutoMapper;
using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using E.Commerce.Domain.Entites.Categories;

namespace E.Commerce.Application.Services
{
    public class CartAppService : ICartAppServices
    {
        private readonly ICartRepository cartRepository;
        private readonly IAsyncRepository<Product> productRepository;
        private readonly IAsyncRepository<Ordered> orderRepository;
        private readonly IMapper mapper;

        public CartAppService(ICartRepository cartRepository,
            IAsyncRepository<Product> productRepository,
            IAsyncRepository<Ordered> orderRepository, IMapper mapper)
        {
            this.cartRepository = cartRepository;
            this.productRepository = productRepository;
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public async Task<Response<CartResponseDto>> AddProductToCart(CartRequestDto cart)
        {
            Response<CartResponseDto> response = new Response<CartResponseDto>();
            var product = await productRepository.GetByIDAsync(cart.ProductId);
            if (product != null)
            {
                if (product.Quantity >= cart.Quantity)
                {
                    var cartdb = mapper.Map<Cart>(cart);
                    cartdb.TotalPrice = product.Price * cart.Quantity;
                    var data = await cartRepository.AddAsync(cartdb);
                    var added = mapper.Map<CartResponseDto>(data);

                    response.Data = added;
                }
                else
                {
                    response.ErrorMessage = "Out Of Stock";
                }
            }
            else
            {
                response.ErrorMessage = "Product not found";
            }
            return response;
        }

        public async Task<CartResponseDto> DeleteFromCartbyID(int ProductId)
        {
            var data = await cartRepository.DeleteByIdAsync(ProductId);
            var result = mapper.Map<CartResponseDto>(data);
            return result;
        }

        public async Task<List<CartResponseDto>> GetCartbyUserID(Guid userId)
        {
            var data = await cartRepository.GetUserWithCartAsync(userId);
            var result = mapper.Map<List<CartResponseDto>>(data);
            return result;
        }

        public async Task<CartResponseDto> UpdateCart(CartRequestDto cart)
        {
            var old = mapper.Map<Cart>(cart);
            var data = await cartRepository.UpdateAsync(old);
            var result = mapper.Map<CartResponseDto>(data);
            return result;
        }
        public async Task<OrderedDto> CheckOut(Guid userId)
        {
            var userCartList = await cartRepository.GetUserWithCartAsync(userId);

            var orderProducts = new List<OrderProduct>();

            for (int i = 0; i < userCartList.Count; i++)
            {
                orderProducts.Add(new OrderProduct
                {
                    ProductID = userCartList[i].ProductId,
                    Quantity = userCartList[i].Quantity,
                    TotalPrice = userCartList[i].TotalPrice,
                });
            }

            var order = await orderRepository.AddAsync(
                new Ordered
                {
                    UserId = userId,
                    Date = DateTime.Now,
                    TotalPrice = orderProducts.Sum(o => o.TotalPrice),
                    OrderProducts = orderProducts
                });


            await cartRepository.DeleteCartsAsync(userCartList);
            return new OrderedDto
            {
                TotalPrice = order.TotalPrice,
                Date = order.Date,
                UserId = order.UserId
            };
        }
    }
}
