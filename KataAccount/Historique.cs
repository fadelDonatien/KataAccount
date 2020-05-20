using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KataAccount
{
    public interface Historique <T> where T : class
    {
       List<T> getAllHistory();
       void addHistory(T record);
        
        /// <summary>
        /// A faire  
        /// </summary>
       void printStream(StreamWriter fichier);
      
    }
}
