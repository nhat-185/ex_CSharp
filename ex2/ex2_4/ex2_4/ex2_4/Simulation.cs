    class Simulation
    {
        public static void Main(string[] args)
        {
            Box box = new Box(4, 5); // Tạo hộp với kích thước 4x5

            // Thêm một số hạt vào hộp
            Particle particle1 = new Particle(1, 1);
            Particle particle2 = new Particle(2, 2);
            Particle particle3 = new Particle(3, 3);

            box.AddParticle(particle1);
            box.AddParticle(particle2);
            box.AddParticle(particle3);

        // Mô phỏng 10 lần
        for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"\nStep {i + 1}:");
                box.Step();
                box.DisplayParticles();
                Console.WriteLine($"Total particles: {box.Particles.Count}");
            }
        }
    }