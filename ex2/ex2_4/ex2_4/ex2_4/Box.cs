using System;
using System.Collections.Generic;

class Box
{
    private int width;
    private int height;
    private List<Particle> particles = new List<Particle>();
    private static readonly Random rand = new Random();  // random dùng chung, sinh hạt ngẫu nhiên khi va chạm

    public Box(int width, int height)  // Constructor nhận chiều rộng và chiều cao
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and Height must be positive.");
        this.width = width;
        this.height = height;
    }

    public void AddParticle(Particle particle)  // Thêm hạt vào hộp
    {
        if (particle.X < 0 || particle.Y < 0 || particle.X >= width || particle.Y >= height)
            throw new ArgumentException("Particle is out of bounds.");
        particles.Add(particle);
    }

    public List<Particle> Particles => particles; // Thuộc tính để lấy danh sách các hạt từ ngoài

    public void Step()
    {
        // Di chuyển hạt
        foreach (var particle in particles)
        {
            particle.Move(width, height);
        }

        // Kiểm tra va chạm
        for (int i = 0; i < particles.Count; i++)
        {
            for (int j = i + 1; j < particles.Count; j++)
            {
                if (particles[i].X == particles[j].X && particles[i].Y == particles[j].Y)
                {
                    int newX = rand.Next(0, width);
                    int newY = rand.Next(0, height);
                    particles.Add(new Particle(newX, newY));
                    Console.WriteLine($"New particle created at ({newX}, {newY}) due to overlap at ({particles[i].X}, {particles[i].Y})");
                    return; // chỉ thêm 1 hạt mỗi lượt
                }
            }
        }

        if (particles.Count == 0)
        {
            Console.WriteLine("No particles to move.");
        }
    }

    public void DisplayParticles()
    {
        char[,] grid = new char[height, width];

        // Khởi tạo toàn bộ là khoảng trắng
        for (int y = 0; y < height; y++)
            for (int x = 0; x < width; x++)
                grid[y, x] = ' ';

        // Hiển thị tối đa 3 hạt
        int count = 0;
        foreach (var p in particles)
        {
            if (count >= 3) break;

            if (p.X >= 0 && p.X < width && p.Y >= 0 && p.Y < height)
            {
                grid[p.Y, p.X] = '*';
                count++;
            }
        }

        // In khung trên: 
        Console.Write(" ");
        Console.WriteLine(new string('-', width));

        // In từng dòng từ trên xuống dưới
        for (int y = height - 1; y >= 0; y--)
        {
            Console.Write("|"); 
            for (int x = 0; x < width; x++)
                Console.Write(grid[y, x]);
            Console.WriteLine("|");
        }

        // In khung dưới
        Console.Write(" ");
        Console.WriteLine(new string('-', width));
    }


}