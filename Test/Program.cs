using FastBitmapUtils;
using System.Drawing;

Bitmap bmp = new Bitmap(1024, 1024);
Graphics.FromImage(bmp).Clear(Color.Green);

FastBitmap fast = new FastBitmap(bmp);

for (ushort x = 0; x < 1024; x++)
    for (ushort y = 0; y < 1024; y++)
        fast.SetPixel(x, y, (x & y) == 0 ? Color.Red : Color.Blue);

Bitmap result = fast.GetResult();

result.Save("C:\\test.png");