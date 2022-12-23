using lab9_WebDriver.Data;
using lab9_WebDriver.Pages;


namespace lab9_WebDriver;


public class MyTest : TestsClass
{
    protected override string? Url => "https://5element.by";

    [Test]
    public void Element5SiteTest_1()
    {
        var authorization = new AuthorizationPage(workspace);
        var main = new MainPage(workspace);
        var product = new ProductPage(workspace);

        var defaultUser = MockUserStore.GetDefaultUser();
        authorization.Authorize(defaultUser);
       
        int? expected = product.LikeCount == null? 1 : 1 + product.LikeCount;
        

        main.OpenDiscounts();
        main.OpenSales();
        Thread.Sleep(3000);

        product.Like("763365");
        Thread.Sleep(1000);
        
        var actual = product.LikeCount;
        expected = expected < actual ? expected - 2 : expected;


        Assert.That(actual,Is.EqualTo(expected));

    }
    [Test]
    public void Element5SiteTest_2()
    {
        var authorization = new AuthorizationPage(workspace);
        var main = new MainPage(workspace);
        var product = new ProductPage(workspace);

        var defaultUser = MockUserStore.GetDefaultUser();
        authorization.Authorize(defaultUser);

        int? expected = product.CartCount == null ? 1 : 1 + product.CartCount;
        int? expected2 = null;

        main.OpenTelevisions();

        product.AddToCart("748474");
        Thread.Sleep(1000);
        
        var actual = product.CartCount;

        Assert.That(actual,Is.EqualTo(expected).Or.EqualTo(expected2));

    }
    [Test]
    public void Element5SiteTest_3()
    {
        Assert.DoesNotThrow(() =>
        {
            var authorization = new AuthorizationPage(workspace);
            var main = new MainPage(workspace);
            var product = new ProductPage(workspace);

            var defaultUser = MockUserStore.GetDefaultUser();
            authorization.Authorize(defaultUser);


            main.OpenDiscounts();
            main.OpenSales();

            product.GetNotify("763039");

        });
    }
    [Test]
    public void Element5SiteTest_4()
    {

            var authorization = new AuthorizationPage(workspace);
            var main = new MainPage(workspace);
            var product = new ProductPage(workspace);

            var defaultUser = MockUserStore.GetDefaultUser();
            authorization.Authorize(defaultUser);

            int? expected1 = product.LikeCount == null ? 1 : product.LikeCount - 1;
            int? expected2 = null;


            main.OpenLikedProducts();

            Thread.Sleep(5000);
            product.Dislike("748474");

            Thread.Sleep(1000);

            var actual = product.LikeCount;

        Assert.That(actual, Is.EqualTo(expected1).Or.EqualTo(expected2));
    }
    [Test]
    public void Element5SiteTest_5()
    {
        Assert.DoesNotThrow(() =>
        {
            var authorization = new AuthorizationPage(workspace);
            var main = new MainPage(workspace);

            authorization.Authorize(MockUserStore.GetDefaultUser());
            main.Subscribe();

        });
        
    }
}