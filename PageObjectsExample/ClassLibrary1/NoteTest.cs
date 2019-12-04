using Xunit;

namespace ClassLibrary1
{
    public partial class CommentTests
    {
        public class NoteTest : BaseTest
        {
            [Fact]
            public void Can_publish_new_note()
            {
                var loginPage = LoginPage.Open(GetBrowser());
                var adminPanel = loginPage.Login("automatyzacja", "auto@Zima2019");
                //var Note = LoginPage.CreateToNewestNote();
                
            }

        }
    }
}
