using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class CommentTests
    {
        [Fact]
        public void CanAddNewCommentToLatestNote()
        {
            var blogStartPage = MainPage.Open();
            var note = blogStartPage.NavigateToNewestNote();
            var exampleComment = new ExampleComment();
            var noteWithComment = note.AddComment(exampleComment);

            Assert.True(noteWithComment.Has(exampleComment));

                



        }

    }
}
