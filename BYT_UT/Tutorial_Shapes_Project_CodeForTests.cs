namespace BYT_UT
{
    public class Tests
    {
        private IShape sphere = new Sphere(5);

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
    }
}