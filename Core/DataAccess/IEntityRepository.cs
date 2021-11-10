using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;                                    //Core katmanı herhangi bir yerde kullanabileceğimiz classları barındıran katmandır(Core bizim evrensel katmanımız)
using System.Text;                                                //Core katmanı diğer katmanları referans almaz alırsa zaten bağımlıyız

namespace Core.DataAccess
{       //generic constraint(kısıt)          //generic repository pattern sayesinde farklı varlıklarda aynı fonksiyonları kullandık           //new() :newlenebilir olmalı (interfaceler newlenemeyeceğinden kabul etmez onları)
        //class :referance tip               //IENtitiy :IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()                  //where T:class,IENtity yazmamızın sebebi bunu ımplemente eden bir class'ın kullanabileceklerini belirlemek
    {
        List<T> GetAll(Expression<Func<T,bool>>filter = null);                         //Expression yapısı filtre kullanabilmemizi sağlar
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
