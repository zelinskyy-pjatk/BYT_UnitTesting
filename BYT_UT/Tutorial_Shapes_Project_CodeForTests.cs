namespace BYT_UT
{
    public class Tests
    {
        private IShape sphere = new Sphere(5);

        private IShape cylinder = new Cylinder(4, 5);
        
        private IShape cube = new Cube(5);

        private Rectangle rectangle = new Rectangle(4, 5);


        // -- Sphere Tests -- //
        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestSphereNegativeRadius_PositiveArea()
        {
            sphere = new Sphere(-5);
            Assert.That(sphere.CalculateArea(), Is.Positive);
        }

        // -- Cylinder Tests -- //
        [Test]
        public void TestCylinderCalculateArea_NormalValues()
        {
            double expectedValue = 2 * Math.PI * 4 * (4 + 5);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(expectedValue).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume_NormalValues()
        {
            double expectedValue = Math.PI * Math.Pow(4, 2) * 5;
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(expectedValue).Within(0.001));
        }

        [Test]
        public void TestCylinderZeroRadius_ZeroArea()
        {
            cylinder = new Cylinder(0, 5);
            Assert.That(cylinder.CalculateArea(), Is.Zero);
        }

        [Test]
        public void TestCylinderZeroHeight_CorrectArea()
        {
            cylinder = new Cylinder(4, 0);
            double expectedValue = 2 * Math.PI * 4 * (4 + 0);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(expectedValue).Within(0.001));
        }
        
        [Test]
        public void TestCylinderZeroRadius_ZeroVolume()
        {
            cylinder = new Cylinder(0, 5);
            Assert.That(cylinder.CalculateVolume(), Is.Zero);
        }

        [Test]
        public void TestCylinderZeroHeight_ZeroVolume()
        {
            cylinder = new Cylinder(4, 0);
            Assert.That(cylinder.CalculateVolume(), Is.Zero);
        }
    
        // -- Cube Tests -- //
        [Test]
        public void TestCubeCalculateArea()
        {
            double expectedValue = 6 * Math.Pow(5, 2);
            Assert.That(cube.CalculateArea(), Is.EqualTo(expectedValue).Within(0.001));
        }
        
        [Test]
        public void TestCubeCalculateVolume()
        {
            double expectedValue = Math.Pow(5, 3);
            Assert.That(cube.CalculateVolume(), Is.EqualTo(expectedValue).Within(0.001));
        }
        
        [Test]
        public void TestCubeZeroSide_ZeroArea()
        {
            cube = new Cube(0);
            Assert.That(cube.CalculateArea(), Is.Zero);
        }

        [Test]
        public void TestCubeZeroSide_ZeroVolume()
        {
            cube = new Cube(0);
            Assert.That(cube.CalculateVolume(), Is.Zero);
        }

        // -- Rectangle Tests -- //
        [Test]
        public void TestRectangleCalculateArea()
        {
            double expectedValue = 4 * 5;
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(expectedValue).Within(0.001));
        }
        
        [Test]
        public void TestRectangleCalculateVolume_ZeroVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.Zero);
        }

        [Test]
        public void TestRectangleZeroLength_ZeroArea()
        {
            rectangle = new Rectangle(0, 5);
            Assert.That(rectangle.CalculateArea(), Is.Zero);
        }
        
        
        [Test]
        public void TestRectangleZeroWidth_ZeroArea()
        {
            rectangle = new Rectangle(4, 0);
            Assert.That(rectangle.CalculateArea(), Is.Zero);
        }
        
        [Test]
        public void TestRectangleZeroSides_ZeroVolume()
        {
            rectangle = new Rectangle(0, 0);
            Assert.That(rectangle.CalculateVolume(), Is.Zero);
        }
    }
}