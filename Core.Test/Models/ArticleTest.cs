using Core.Models;
using Xunit;

namespace Core.Test.Models
{
    public class ArticleTest
    {
        private Article _article;

        public ArticleTest()
        {
            _article = new Article();
        }

        [Fact]
        public void ArticleClass_Exists()
        {
            Assert.NotNull(_article);
        }
        
        [Fact]
        public void ArticleClass_HasId_WithTypeInt()
        {
            var expected = 1;
            _article.Id = 1;
            Assert.Equal(expected, _article.Id);
            Assert.True(_article.Id is int);
        }
        
        [Fact]
        public void ArticleClass_HasTitle_WithTypeString()
        {
            var expected = "Test title";
            _article.Title = "Test title";
            Assert.Equal(expected, _article.Title);
            Assert.True(_article.Title is string);
        }
        
        [Fact]
        public void ArticleClass_HasMainText_WithTypeString()
        {
            var expected = "Test main text";
            _article.MainText = "Test main text";
            Assert.Equal(expected, _article.MainText);
            Assert.True(_article.MainText is string);
        }
        
        [Fact]
        public void ArticleClass_HasSubText_WithTypeString()
        {
            var expected = "Test sub text";
            _article.SubText = "Test sub text";
            Assert.Equal(expected, _article.SubText);
            Assert.True(_article.SubText is string);
        }

        [Fact]
        public void ArticleClass_HasImage_WithTypeImage()
        {
            var expected = "Test image";
            _article.Image = "Test image";
            Assert.Equal(expected, _article.Image);
            Assert.True(_article.Image is string);
        }
    }
}