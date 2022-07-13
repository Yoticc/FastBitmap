using FastBitmapUtils;
using System.Drawing;

Bitmap bmp = new Bitmap(1024, 1024);
Graphics.FromImage(bmp).Clear(Color.Blue);

FastBitmap fast = new FastBitmap(bmp);

for (ushort x = 0; x < 1024; x++)
    for (ushort y = 0; y < 1024; y++)
        if ((x & y) == 0)
            fast.SetPixel(x, y, Color.Red);

Bitmap result = fast.GetResult();

result.Save("C:\\test.png");