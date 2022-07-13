// Nedded usings
using FastBitmapUtils;
using System.Drawing;

Bitmap bmp = new Bitmap(1024, 1024); // Initialize bitmap or get own from file

FastBitmap fast = new FastBitmap(bmp); // Initialize bitmap wrapper

for (ushort x = 0; x < 1024; x++)
    for (ushort y = 0; y < 1024; y++)
        fast.SetPixel(x, y, (x & y) == 0 ? Color.Red : Color.Blue); // Use fast SetPixel in wrapper

Bitmap result = fast.GetResult(); // Get result

result.Save("C:\\test.png"); // Save the image as file
