using System.Collections.Generic;
using System.IO;
using Core.IServices;
using Core.Models;
using Domain.IRepository;

namespace Domain.Service
{
    public class ArticleService: IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository =
                articleRepository ?? throw new InvalidDataException("Article repository must not be null");
        }
        
        public List<Article> GetAllArticles()
        {
            return _articleRepository.GetAllArticles();
        }

        public bool DeleteArticle(int id)
        {
            return _articleRepository.DeleteArticle(id);
        }

        public bool CreateArticle(Article article)
        {
            return _articleRepository.CreateArticle(article);
        }

        public bool UpdateArticle(Article article)
        {
            return _articleRepository.UpdateArticle(article);
        }

        public Article GetArticleById(int id)
        {
            return _articleRepository.GetArticleById(id);
        }
    }
}