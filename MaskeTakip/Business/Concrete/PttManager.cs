using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        //pttmanager 'ın bağımlı olduğu sınıf yerine o sınıfların interface'ini yazıyoruz.
        // interface ler birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalrını sağlarlar.
        // buradakine göre yabancı uyrukluyu ayrı check ederim kontrol ederim(maske verilcek mi verilmicek mi)
        // yabancı uyrukluyu ayrı kontrol ederim. Interface bu birbirinin alternatifi olan sistemin farklı implementasyon yapmalarını sağlar.
        // yabancı uyruklu başvurabilir listelenebilir kontrol edebilirim aynı şekilde vatandaşımda başvurabilir listelenebilir kontrol edebilrim.
        
        //dependcy Injection
        
        // interface ler new lenemezler referans tutucudurlar

        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //constructor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
