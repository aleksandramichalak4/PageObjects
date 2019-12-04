using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Xunit;

namespace ClassLibrary1
{
    public class CommentTests : BaseTest
    {
        [Fact]
        public void CanAddNewCommentToLatestNote()
        {
            var blogStartPage = MainPage.Open(GetBrowser());
            var note = blogStartPage.NavigateToNewestNote();
            var exampleComment = new ExampleComment();
            var noteWithComment = note.AddComment(exampleComment);

            Assert.True(noteWithComment.Has(exampleComment));


        }

        public class NoteTest : BaseTest
        {
            [Fact]
            public void Can_publish_new_note()
            {

            }

        }
    }
}
