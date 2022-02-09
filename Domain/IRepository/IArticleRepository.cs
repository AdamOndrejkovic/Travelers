using System.Collections.Generic;
using Core.Models;

namespace Domain.IRepository
{
    public interface IArticleRepository
    {
        List<Article> GetAllArticles();
        bool DeleteArticle(int id);
        bool UpdateArticle(Article article);
        bool CreateArticle(Article article);

        Article GetArticleById(int id);
    }
}