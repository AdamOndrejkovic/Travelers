using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core.Models;
using DataAccess.Entities;
using Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class ArticleRepository: IArticleRepository
    {
        private readonly TravelersDbContext _context;

        public ArticleRepository(TravelersDbContext context)
        {
            _context = context ?? throw new InvalidDataException("Article Repository can not be null");
        }
        public List<Article> GetAllArticles()
        {
            return _context.Articles.Select(ae => new Article()
            {
                Id = ae.Id,
                Title = ae.Title,
                MainText = ae.MainText,
                SubText = ae.SubText,
                Image = ae.Image

            }).ToList();
        }

        public bool DeleteArticle(int id)
        {
            var articleToRemove = _context.Articles.Where(a => a.Id == id);
            if (articleToRemove != null)
            {
                _context.RemoveRange(articleToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateArticle(Article article)
        {
            var entity = new ArticleEntity()
            {
                Id = article.Id,
                Title = article.Title,
                MainText = article.MainText,
                SubText = article.SubText,
                Image = article.Image
                
            };

            if (entity == null) return false;
            _context.Update(entity);
            _context.SaveChanges();
            return true;
        }

        public bool CreateArticle(Article article)
        {
            var entity = new ArticleEntity()
            {
                Id = article.Id,
                Title = article.Title,
                MainText = article.MainText,
                SubText = article.SubText,
                Image = article.Image
                
            };
            _context.Articles.Attach(entity).State = EntityState.Added;
            _context.SaveChanges();
            return true;
        }

        public Article GetArticleById(int id)
        {
            var article = _context.Articles.FirstOrDefault(ae => id.Equals(ae.Id));
            if (article != null)
            {
                return new Article()
                {
                    Id = article.Id,
                    Title = article.Title,
                    MainText = article.MainText,
                    SubText = article.SubText,
                    Image = article.Image
                };
            }
            return null;
        }
    }
}