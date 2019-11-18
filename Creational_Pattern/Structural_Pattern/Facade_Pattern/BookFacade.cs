//--------------------------------------------------------------------------------------------------------------------
// <Copyright file="BookFacade.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Structural_Pattern.Facade_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BookFacade
    {
        /// <summary>
        /// BookClass as class
        /// </summary>
        private Book book;

        /// <summary>
        /// BookTypeClass as class
        /// </summary>
        private BookType bookType;

        /// <summary>
        /// BookInfoClass as class
        /// </summary>
        private BookInfo bookInfo;

        /// <summary>
        /// UserDataClass as class
        /// </summary>
        private UserData userData;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookFacadeClass"/> class.
        /// </summary>
        public BookFacade()
        {
            this.book = new Book();
            this.bookType = new BookType();
            this.bookInfo = new BookInfo();
            this.userData = new UserData();
        }

        /// <summary>
        /// CreateBookFunction as function
        /// </summary>
        public void CreateBookFunction()
        {
            try
            {
                Console.WriteLine("Call all function according to the class");
                this.book.SetOfBook();
                this.bookType.SetOfBookDetails();
                this.bookInfo.BookInformation();
                this.userData.UserDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
