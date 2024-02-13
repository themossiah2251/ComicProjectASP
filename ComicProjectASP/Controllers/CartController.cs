 using ComicProjectASP.Data;
using ComicProjectASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ComicProjectASP.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager; // Add UserManager for Identity operations

        // Inject both ApplicationDbContext and UserManager into your controller
        public CartController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager; // Assign UserManager
        }

        // Display the cart
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User); // Get current user's ID
            // Filter cart items by the current user's cart ID
            var userCart = await _context.Cart.FirstOrDefaultAsync(c => c.UserId == userId);
            if (userCart == null)
            {
                // Handle case where user does not have a cart
                return View(new CartViewModel { CartItems = new List<CartDetails>() });
            }

            var cartItems = await _context.CartDetails
                .Include(cd => cd.Products)
                .Where(cd => cd.CartId == userCart.Id)
                .ToListAsync();

            var viewModel = new CartViewModel
            {
                CartItems = cartItems
            };

            return View(viewModel);
        }

        // Add item to cart
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity)
        {
            var userId = _userManager.GetUserId(User); // Get current user's ID
            var userCart = await _context.Cart.FirstOrDefaultAsync(c => c.UserId == userId);
            if (userCart == null)
            {
                userCart = new Cart { UserId = userId };
                _context.Cart.Add(userCart);
                await _context.SaveChangesAsync();
            }

            var cartDetail = await _context.CartDetails
                .FirstOrDefaultAsync(cd => cd.CartId == userCart.Id && cd.ProductId == productId);

            if (cartDetail != null)
            {
                // Product is already in the cart, update its quantity
                cartDetail.Quantity += quantity;
            }
            else
            {
                // Product is not in the cart, add a new cart detail
                var product = await _context.Products.FindAsync(productId);
                if (product == null)
                {
                    // Handle the case where the product doesn't exist.
                    return NotFound();
                }
                cartDetail = new CartDetails
                {
                    CartId = userCart.Id,
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = product.Price // Assuming Price is a property of your Product model
                };
                _context.CartDetails.Add(cartDetail);
            }

            await _context.SaveChangesAsync();

            // If this is an AJAX call, you might return a JSON response
            return Json(new { success = true, message = "Item added to cart!" });
            // Or if you're not using AJAX, redirect to the Cart page
            // return RedirectToAction("Index");
        

         await _context.CartDetails
                .FirstOrDefaultAsync(cd => cd.CartId == userCart.Id && cd.ProductId == productId);

            if (cartDetail != null)
            {
                cartDetail.Quantity += quantity;
            }
            else
            {
                var product = await _context.Products.FindAsync(productId);
                if (product != null)
                {
                    cartDetail = new CartDetails
                    {
                        CartId = userCart.Id,
                        ProductId = productId,
                        Quantity = quantity,
                        UnitPrice = product.Price // Assuming Price is a field in Products
                    };
                    _context.CartDetails.Add(cartDetail);
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int cartDetailId)
        {
            var cartItem = await _context.CartDetails.FindAsync(cartDetailId);
            if (cartItem != null)
            {
                _context.CartDetails.Remove(cartItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCart(int cartDetailId, int quantity)
        {
            var cartItem = await _context.CartDetails.FindAsync(cartDetailId);
            if (cartItem != null && quantity > 0) // Ensure quantity is positive
            {
                cartItem.Quantity = quantity;
                await _context.SaveChangesAsync();
            }
            else if (cartItem != null && quantity <= 0) // Remove item if quantity is zero or negative
            {
                _context.CartDetails.Remove(cartItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
            [HttpPost]
            public async Task<IActionResult> UpdateCartItemQuantity(int cartDetailId, int quantity)
            {
                var cartItem = await _context.CartDetails.FindAsync(cartDetailId);
                if (cartItem != null)
                {
                    if (quantity > 0)
                    {
                        cartItem.Quantity = quantity; // Update to specific quantity
                    }
                    else
                    {
                        _context.CartDetails.Remove(cartItem); // Remove if quantity is 0 or less
                    }
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
        } }

