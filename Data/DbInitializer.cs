using Microsoft.EntityFrameworkCore;
using vphone.Models;

namespace vphone.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QLQuanDTContext(serviceProvider.GetRequiredService<DbContextOptions<QLQuanDTContext>>()))
            {
                context.Database.EnsureCreated();
                if (context.Users.Any())
                {
                    return;
                }
                var users = new User[]
                {
                    new User{ Name = "Nguyễn Văn Triệu", Email="admin@gmail.com", Password = "123456", Address="Nam Định", Phone="0123456789"},
                    new User{ Name = "Nguyễn Danh Trường", Email="truong@gmail.com", Password = "123456", Address="Hà Nội", Phone="0123456789"},
                    new User{Name = "Nguyễn Tùng Lâm", Email="lam@gmail.com", Password = "123456", Address="Hà Nội", Phone="0123456789"},
                    new User{Name = "Bùi Xuân Nam", Email="nam@gmail.com", Password = "123456", Address="Hà Nội", Phone="0123456789"},
                    new User{Name = "Vũ Đức Lân", Email="lan@gmail.com", Password = "123456", Address="Hà Nội", Phone="0123456789"},
                };
                foreach (var user in users)
                {
                    context.Users.Add(user);
                }
                context.SaveChanges();
                ////if (context.categories.any())
                ////{
                ////    return;
                ////}
                ////var categories = new category[]
                ////{
                ////    new category{id = 1, title = "iphone", slug ="iphone", description = "điện thoại iphone" ,userid=1},
                ////    new category{id = 2, title = "samsung", slug ="samsung", description = "điện thoại samsung" ,userid=1 },
                ////    new category{id = 3, title = "xiaomi", slug ="xiaomi", description = "điện thoại xiaomi" ,userid=1 }

                ////};
                ////foreach (var category in categories)
                ////{
                ////    context.categories.add(category);
                ////}
                ////context.savechanges();

                ////if (context.products.any())
                ////{
                ////    return;
                ////}
                ////var products = new product[]
                ////{
                ////    new product{id = 1 ,userid=1, name = "điện thoại di động iphone 15 pro max (512gb) - chính hãng vn/a", price = 39750000,isstock = true, catid = 1, image = "iphone-15-pro-max-blue-titanium-pure.png"/*thêm vào image bên ngoài*/, description = "iphone 15 pro max đem đến cho người dùng đa dạng sự lựa chọn với ba phiên bản bộ nhớ trong lần lượt là 256gb/512gb/1tb và bốn lựa chọn màu gồm titan tự nhiên/titan trắng/titan xanh/titan đen. ngoài việc sử dụng chất liệu titan mới, những cải tiến về cấu hình được apple cập nhật và trang bị hứa hẹn đem đến trải nghiệm người dùng nâng cao hơn.", slug = "dien-thoai-di-dong-iphone-15-pro-max-512gb-chinh-hang-vna", isfeatured = true, screentech = "màn hình super retina xdr, tấm nền oled, dynamic island, công nghệ promotion với tốc độ làm mới thích ứng lên đến 120hz, màn hình luôn bật, màn hình hdr, tỷ lệ tương phản 2.000.000:1 (tiêu chuẩn), màn hình true tone, màn hình có dải màu rộng (p3), haptic touch", resolution = "1290 x 2796, chính: 48mp, khẩu độ ƒ/1.78, ultra wide: 12mp, khẩu độ ƒ/2.2, telephoto: 12mp, khẩu độ ƒ/2.8, camera trước truedepth 12mp, khẩu độ ƒ/1.9", screensize = "6.7\"", operatingsystem = "ios 17", processor = "a17 pro", internalmemory = "512gb", ram = "8gb", batterycapacity = "4.422mah"},
                ////    new product{id = 2 ,userid=1, name = "điện thoại di động iphone 15 pro max (256gb) - chính hãng vn/a", price = 33850000,isstock = true, catid = 1, image = "iphone-15-pro-max-natural-titanium-pure.png", description = "iphone 15 pro max đem đến cho người dùng đa dạng sự lựa chọn với ba phiên bản bộ nhớ trong lần lượt là 256gb/512gb/1tb và bốn lựa chọn màu gồm titan tự nhiên/titan trắng/titan xanh/titan đen. ngoài việc sử dụng chất liệu titan mới, những cải tiến về cấu hình được apple cập nhật và trang bị hứa hẹn đem đến trải nghiệm người dùng nâng cao hơn.", slug = "dien-thoai-di-dong-iphone-15-pro-max-256gb-chinh-hang-vna", isfeatured = true, screentech = " màn hình super retina xdr, tấm nền oled, dynamic island, công nghệ promotion với tốc độ làm mới thích ứng lên đến 120hz, màn hình luôn bật, màn hình hdr, tỷ lệ tương phản 2.000.000:1 (tiêu chuẩn), màn hình true tone, màn hình có dải màu rộng (p3), haptic touch", resolution = "1290 x 2796, chính: 48mp, khẩu độ ƒ/1.78, ultra wide: 12mp, khẩu độ ƒ/2.2, telephoto: 12mp, khẩu độ ƒ/2.8, camera trước truedepth 12mp, khẩu độ ƒ/1.9", screensize = "6.7\"", operatingsystem = "ios 17", processor = "a17 pro", internalmemory = "256gb", ram = "8gb", batterycapacity = "4.422mah"},
                ////    new product{id = 3 ,userid=1, name = "điện thoại di động iphone 15 pro max (1t) - chính hãng vn/a", price = 45990000,isstock = true, catid = 1, image = "iphone-15-pro-max-white-titanium-pure.png", description = "iphone 15 pro max đem đến cho người dùng đa dạng sự lựa chọn với ba phiên bản bộ nhớ trong lần lượt là 256gb/512gb/1tb và bốn lựa chọn màu gồm titan tự nhiên/titan trắng/titan xanh/titan đen. ngoài việc sử dụng chất liệu titan mới, những cải tiến về cấu hình được apple cập nhật và trang bị hứa hẹn đem đến trải nghiệm người dùng nâng cao hơn.", slug = "dien-thoai-di-dong-iphone-15-pro-max-1t-chinh-hang-vna", isfeatured = true, screentech = "màn hình super retina xdr, tấm nền oled, dynamic island, công nghệ promotion với tốc độ làm mới thích ứng lên đến 120hz, màn hình luôn bật, màn hình hdr, tỷ lệ tương phản 2.000.000:1 (tiêu chuẩn), màn hình true tone, màn hình có dải màu rộng (p3), haptic touch", resolution = "1290 x 2796, chính: 48mp, khẩu độ ƒ/1.78, ultra wide: 12mp, khẩu độ ƒ/2.2, telephoto: 12mp, khẩu độ ƒ/2.8, camera trước truedepth 12mp, khẩu độ ƒ/1.9", screensize = "6.7\"", operatingsystem = "ios 17", processor = "a17 pro", internalmemory = "1tb", ram = "8gb", batterycapacity = "4.422mah"},
                ////    new product{id = 4 ,userid=1, name = "điện thoại di động iphone 15 pro (1tb) - chính hãng vn/a", price = 42490000,isstock = true, catid = 1, image = "iphone-15-pro-natural-titanium-pure.png", description = "iphone 15 pro sở hữu màn hình super retina xdr oled 6,1 inch với tần số quét 120hz và độ sáng lên tới 2000 nit. bên cạnh đó, với con chip a17 pro mạnh mẽ, máy mang đến hiệu năng cao cùng khả năng xử lý đa nhiệm tuyệt vời. về camera, iphone 15 pro được trang bị cụm camera gồm 3 ống kính: 48mp cho góc rộng, 12mp cho tele và góc siêu rộng cao cấp.", slug = "dien-thoai-di-dong-iphone-15-pro-1t-chinh-hang-vna", isfeatured = true, screentech = "màn hình super retina xdr, tấm nền oled, dynamic island, công nghệ promotion với tốc độ làm mới thích ứng lên đến 120hz, màn hình luôn bật, màn hình hdr, tỷ lệ tương phản 2.000.000:1 (tiêu chuẩn), màn hình true tone, màn hình có dải màu rộng (p3), haptic touch", resolution = "1179 x 2556, chính: 48mp, khẩu độ ƒ/1.78, ultra wide: 12mp, khẩu độ ƒ/2.2, telephoto: 12mp, khẩu độ ƒ/2.8, camera trước truedepth 12mp, khẩu độ ƒ/1.9", screensize = " 6.1\"", operatingsystem = " ios 17", processor = "a17 pro", internalmemory = "1tb", ram = "8gb", batterycapacity = "3.274 mah" },
                ////    new product{id = 5 ,userid=1, name = "điện thoại di động iphone 15 pro (512gb) - chính hãng vn/a", price = 36490000,isstock = true, catid = 1, image = "iphone-15-pro-white-titanium-pure.png", description = "iphone 15 pro sở hữu màn hình super retina xdr oled 6,1 inch với tần số quét 120hz và độ sáng lên tới 2000 nit. bên cạnh đó, với con chip a17 pro mạnh mẽ, máy mang đến hiệu năng cao cùng khả năng xử lý đa nhiệm tuyệt vời. về camera, iphone 15 pro được trang bị cụm camera gồm 3 ống kính: 48mp cho góc rộng, 12mp cho tele và góc siêu rộng cao cấp.", slug = "dien-thoai-di-dong-iphone-15-pro-512gb-chinh-hang-vna", isfeatured = true, screentech = "màn hình super retina xdr, tấm nền oled, dynamic island, công nghệ promotion với tốc độ làm mới thích ứng lên đến 120hz, màn hình luôn bật, màn hình hdr, tỷ lệ tương phản 2.000.000:1 (tiêu chuẩn), màn hình true tone, màn hình có dải màu rộng (p3), haptic touch", resolution = "1179 x 2556, chính: 48mp, khẩu độ ƒ/1.78, ultra wide: 12mp, khẩu độ ƒ/2.2, telephoto: 12mp, khẩu độ ƒ/2.8, camera trước truedepth 12mp, khẩu độ ƒ/1.9", screensize = "6.1\"", operatingsystem = "ios 17", processor = "a17 pro", internalmemory = "512gb", ram = "8gb", batterycapacity = "3.274 mah"},
                ////    new product{id = 6 ,userid=1, name = "điện thoại di động iphone 15 pro (256gb) - chính hãng vn/a", price = 29990000,isstock = true, catid = 1, image = "iphone-15-pro-black-titanium-pure.png", description = "iphone 15 pro sở hữu màn hình super retina xdr oled 6,1 inch với tần số quét 120hz và độ sáng lên tới 2000 nit. bên cạnh đó, với con chip a17 pro mạnh mẽ, máy mang đến hiệu năng cao cùng khả năng xử lý đa nhiệm tuyệt vời. về camera, iphone 15 pro được trang bị cụm camera gồm 3 ống kính: 48mp cho góc rộng, 12mp cho tele và góc siêu rộng cao cấp.", slug = "dien-thoai-di-dong-iphone-15-pro-256gb-chinh-hang-vna", isfeatured = true, screentech = "màn hình super retina xdr, tấm nền oled, dynamic island, công nghệ promotion với tốc độ làm mới thích ứng lên đến 120hz, màn hình luôn bật, màn hình hdr, tỷ lệ tương phản 2.000.000:1 (tiêu chuẩn), màn hình true tone, màn hình có dải màu rộng (p3), haptic touch", resolution = " 1179 x 2556, chính: 48mp, khẩu độ ƒ/1.78, ultra wide: 12mp, khẩu độ ƒ/2.2, telephoto: 12mp, khẩu độ ƒ/2.8, camera trước truedepth 12mp, khẩu độ ƒ/1.9", screensize = "6.1\"", operatingsystem = "ios 17", processor = "a17 pro", internalmemory = "256gb", ram = "8gb", batterycapacity = "3.274 mah"},
                ////    new product{id = 7 ,userid=1, name = "điện thoại di động iphone 15 pro (128gb) - chính hãng vn/a", price = 27490000,isstock = true, catid = 1, image = "iphone-15-pro-blue-titanium-pure.png", description = "iphone 15 pro sở hữu màn hình super retina xdr oled 6,1 inch với tần số quét 120hz và độ sáng lên tới 2000 nit. bên cạnh đó, với con chip a17 pro mạnh mẽ, máy mang đến hiệu năng cao cùng khả năng xử lý đa nhiệm tuyệt vời. về camera, iphone 15 pro được trang bị cụm camera gồm 3 ống kính: 48mp cho góc rộng, 12mp cho tele và góc siêu rộng cao cấp.", slug = "dien-thoai-di-dong-iphone-15-pro-128gb-chinh-hang-vna", isfeatured = true, screentech = "màn hình super retina xdr, tấm nền oled, dynamic island, công nghệ promotion với tốc độ làm mới thích ứng lên đến 120hz, màn hình luôn bật, màn hình hdr, tỷ lệ tương phản 2.000.000:1 (tiêu chuẩn), màn hình true tone, màn hình có dải màu rộng (p3), haptic touch", resolution = "1179 x 2556, chính: 48mp, khẩu độ ƒ/1.78, ultra wide: 12mp, khẩu độ ƒ/2.2, telephoto: 12mp, khẩu độ ƒ/2.8, camera trước truedepth 12mp, khẩu độ ƒ/1.9", screensize = " 6.1\"", operatingsystem = " ios 17", processor = "a17 pro", internalmemory = "128gb", ram = "8gb", batterycapacity = "3.274 mah" },
                ////      new product{id = 8,
                ////        userid=1,
                ////        name ="điện thoại di động  samsung galaxy z fold5",
                ////        price = 32990000,
                ////        isstock = true,
                ////        catid = 2,
                ////        image = "zfold5.png",
                ////        description = "#",
                ////        slug = "galaxy z fold5",
                ////        isfeatured = false,
                ////        screentech = "dynamic amoled 2x",
                ////        resolution = "2176 x 1812 with 2316 x 904",
                ////        screensize = "7.6 inch and 6,7 inch",
                ////        operatingsystem = "oneui 5.1.1 / android 13",
                ////        processor = "snapdragon® 8 gen 2",
                ////        internalmemory = "256gb",
                ////        ram = "12gb",
                ////        batterycapacity = "4400 mah"
                ////    },
                ////     new product{id = 9,
                ////        userid=1,
                ////        name ="điện thoại di động xiaomi 12t (8gb/128gb) - chính hãng",
                ////        price = 9880000,
                ////        isstock = true,
                ////        catid = 3,
                ////        image = "xiaomi12t.png",
                ////        description = "#",
                ////        slug = "xiaomi 12t",
                ////        isfeatured = false,
                ////        screentech = "amoled dotdisplay",
                ////        resolution = "1220x2712",
                ////        screensize = "6,67 inch",
                ////        operatingsystem = "miui 13, android 12",
                ////        processor = "dimensity 8100-ultra",
                ////        internalmemory = "128gb",
                ////        ram = "8gb",
                ////        batterycapacity ="5000mah"
                ////    },
                ////    //new product{id = 15, name = "", price = ,isstock = , catid = , image = , description = , slug = , isfeatured = , screentech = "", resolution = "", screensize = "", operatingsystem = "", processor = "", internalmemory = "", ram = "", batterycapacity = "", createdat =, updatedat = , cat = },

                ////};
                ////foreach (var product in products)
                ////{
                ////    context.products.add(product);
                ////}
                //context.savechanges();
            }
        }
    }
}
