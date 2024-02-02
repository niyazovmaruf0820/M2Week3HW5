using task2;

PhotoBook photoBook1 = new PhotoBook();
System.Console.WriteLine(photoBook1.GetNumberPage());

PhotoBook photoBook2 = new PhotoBook(24);
System.Console.WriteLine(photoBook2.GetNumberPage());

BigPhotoBook bigPhotoBook = new BigPhotoBook();
System.Console.WriteLine(bigPhotoBook.GetNumberPage());