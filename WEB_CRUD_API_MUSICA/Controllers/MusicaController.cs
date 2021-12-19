using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_CRUD_API_MUSICA.Models;

namespace WEB_CRUD_API_MUSICA.Controllers
{
    public class MusicaController : ApiController
    {
        Entities db = new Entities();

        //ADICIONAR
        public string Post(Musica musica)
        {
            db.Musicas.Add(musica);
            db.SaveChanges();
            return "Música adicionada!";
        }

        //EXIBIR TODOS OS REGISTROS
        public IEnumerable<Musica> Get()
        {
            return db.Musicas.ToList();

        }

        //PROCURAR
        public Musica Get(int id)
        {
            Musica musica = db.Musicas.Find(id);
            return musica;
        }

        //ATUALIZAR
        public String Put(int id, Musica musica)
        {
            var musica_ = db.Musicas.Find(id);
            musica_.descricao = musica.descricao;
            db.Entry(musica_).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return "Musica atualizada";

        }

        //DELETAR
        public String Del(int id)
        {
            Musica musica = db.Musicas.Find(id);
            db.Musicas.Remove(musica);
            db.SaveChanges();
            return "Registro deletado!";
        }


    }
}
