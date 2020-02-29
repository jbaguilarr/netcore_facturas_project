using NetCore.Entities;
using NetCore.Interfaces;
using NetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Repository
{
    public class ProductoRepository: IBussines<Entities.Producto>
    {
        NetCoreContext _dbContext;
        public ProductoRepository(NetCoreContext context)
        {
            _dbContext = context;
        }

        public bool Eliminar(int id)
        {
            using (var oTrans = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    //eliminando persona
                    Producto eproducto = this._dbContext.Producto.FirstOrDefault(e => e.Id == id);
                    this._dbContext.Producto.Remove(eproducto);
                    this._dbContext.SaveChanges();

                    oTrans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    oTrans.Rollback();
                    throw ex;
                }
            }
        }

        public Entities.Producto GetEntity(int id)
        {
            try
            {
                return this._dbContext.Producto.FirstOrDefault(e => e.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Entities.Producto> GetLista()
        {
            try
            {
                return this._dbContext.Producto.OrderByDescending(e => e.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Guardar(Entities.Producto eEntidad)
        {
            using (var oTrans = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    //registrando persona
                    this._dbContext.Producto.Add(eEntidad);
                    this._dbContext.SaveChanges();

                    oTrans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    oTrans.Rollback();
                    throw ex;
                }
            }
        }

        public bool Modificar(Entities.Producto eEntidad)
        {
            using (var oTrans = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    //modificando persona
                    this._dbContext.Producto.Update(eEntidad);
                    this._dbContext.SaveChanges();

                    oTrans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    oTrans.Rollback();
                    throw ex;
                }
            }
        }
    }
}
