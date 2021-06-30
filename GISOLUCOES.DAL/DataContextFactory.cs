using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISOLUCOES.DAL
{
    public class DataContextFactory
    {

        public static GISOLUCOESDataContext dataContext;

        public static GISOLUCOESDataContext DataContext
        {
            get
            {

                if (dataContext == null)
                {
                    dataContext = new GISOLUCOESDataContext();
                }

                return dataContext;
            }
        }
    }
}
