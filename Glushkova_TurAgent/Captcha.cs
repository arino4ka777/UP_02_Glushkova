using System;
using System.Drawing;

namespace Glushkova_TurAgent
{
    public class Captcha
    {
        private const string __SYMBOLS__ = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

        private Brush[] _colors = {
            Brushes.Black,
            Brushes.Red,
            Brushes.RoyalBlue,
            Brushes.Green };

        private Graphics _graphics;
        private Bitmap _bitmap;
        private Random _random;

        public string CaptchaText { get; private set; }

        public Bitmap CreateCaptcha(int width, int height)
        {
            _bitmap = new Bitmap(width, height);
            _random = new Random();
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);

            string text = string.Empty;

            for (int i = 0; i < 4; i++)
                text += __SYMBOLS__[_random.Next(__SYMBOLS__.Length)];

            CaptchaText = text;

            _graphics.DrawString(text,
                new Font("Arial", 15),
                _colors[_random.Next(_colors.Length)],
                new PointF(_random.Next(0, width - 50), _random.Next(15, height - 15)));

            _graphics.DrawLine(Pens.Black,
                new Point(0, 0),
                new Point(width - 1, height - 1));

            _graphics.DrawLine(Pens.Black,
                new Point(0, height - 1),
                new Point(width - 1, 0));

            for (int i = 0; i < width; ++i)
                for (int j = 0; j < height; ++j)
                    if (_random.Next() % 20 == 0)
                        _bitmap.SetPixel(i, j, Color.White);
            return _bitmap;
        }
    }
}
