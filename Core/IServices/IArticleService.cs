using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IArticleService
    {
        List<Article> GetAllArticles();
        bool DeleteArticle(int id);
        bool CreateArticle(Article article);
        bool UpdateArticle(Article article);
        Article GetArticleById(int id);
    }
}