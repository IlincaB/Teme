using Xunit;

namespace xUnitTestProject
{
    public class OrderControllerTests
    {   private readonly IRepository _repository;

        public OrderControllerTests()
        {
            _repository=new Repository();
        }
        [Fact]
        public void Test1()
        {

        }
    }
}