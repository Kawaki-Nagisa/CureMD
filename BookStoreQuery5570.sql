CREATE TABLE books (
  Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Title VARCHAR(255) NOT NULL,
  Author VARCHAR(255),
  Description TEXT,
  ImageUrl VARCHAR(255)
);

INSERT INTO books (Title, Author, Description, ImageUrl)
VALUES
  ('The Odyssey', 'Homer', 'The Odyssey by Homer is an epic poem that stands as a cornerstone of Western literature, chronicling the adventurous and tumultuous journey of Odysseus, the King of Ithaca, as he strives to return home following the Trojan War. Composed in the 8th century BCE, this timeless tale intertwines themes of heroism, loyalty, and the quest for identity. Odysseus, renowned for his cunning and resourcefulness, faces a decade-long odyssey fraught with perilous encounters and divine interventions. From the wrathful sea god Poseidon to the alluring song of the Sirens, every challenge tests his resilience and wit. Along his voyage, Odysseus navigates encounters with mythical creatures like the Cyclops Polyphemus, the enchantress Circe, and the deadly Scylla and Charybdis. Parallel to Odysseus''s journey is the story of his wife, Penelope, and son, Telemachus, who fend off suitors vying for Penelope''s hand and Ithaca''s throne. Their perseverance and faith in Odysseus''s return highlight the enduring power of love and familial bonds. The Odyssey is more than a tale of adventure; it is a profound exploration of human endurance, the longing for home, and the struggle against fate. Homer''s masterful storytelling and rich characterizations offer readers a timeless reflection on the complexities of life and the resilience of the human spirit. Whether experienced as an enthralling adventure or a philosophical journey, The Odyssey remains a monumental work that continues to captivate and inspire readers across generations.', 'assets/images/Odyssey.jpg'),
  ('Verity', 'Colleen Hoover', 'Verity by Colleen Hoover is a romantic thriller that delves into the dark and twisted world of bestselling novelist Verity Crawford. When Lowen Ashleigh is hired to complete Verity''s popular series, she uncovers a hidden manuscript that reveals Verity''s shocking secrets and sinister intentions. As Lowen becomes more entangled in Verity''s life, she begins to question everything she thought she knew about the enigmatic author. With its mind-bending twists and turns, Verity is a gripping tale of obsession, deceit, and the blurred lines between reality and fiction.', 'assets/images/Verity.jpg'),
  ('Pride and Prejudice', 'Jane Austen', 'A romantic novel about the complex relationships between the Bennett sisters and their various love interests in 19th-century England.', 'assets/images/Pride.jpg'),
  ('The Shining', 'Stephen King', 'Pride and Prejudice by Jane Austen is a timeless romance that follows the lives of the Bennett sisters as they navigate love, family, and social class in 19th-century England. When Elizabeth Bennett meets the wealthy Mr. Darcy, she is immediately put off by his pride and perceived arrogance. However, as they continue to cross paths, Elizabeth begins to see Darcy in a new light, and their initial dislike blossoms into a deep and abiding love. With its witty dialogue, strong female characters, and nuanced exploration of relationships, Pride and Prejudice is a beloved classic that continues to captivate readers with its universal themes and enduring charm.', 'assets/images/Shining.jpg'),
  ('The Song of Ice and Fire', 'George R. R. Martin', 'A Song of Ice and Fire is an epic fantasy series by American novelist and short-story writer George R. R. Martin. The series, currently five books long with a sixth being written, began with the publication of its first volume, A Game of Thrones, in 1991. Every book in the series takes place on the massive, fantastical islands of Westeros and Essos. The characters of A Song of Ice and Fire are all entangled in three primary plotlines. The first is a war that rages between the most powerful families of Westeros. The second is the ominous, more existential threat of the Others, led by the Night King, who rise in the wastes beyond Westeros’s northern wall. The third follows the young, exiled ruler Daenerys Targaryen, daughter of Westeros’s deposed king, and her struggle to take back the Iron Throne. The series is set primarily in the fictional Seven Kingdoms of Westeros, a large, South American-sized continent with an ancient history stretching back thousands of years. The world is morally ambiguous, bringing into question our conceptions ofgood and evil. The characters are complex and often morally gray, and the series is known for its graphic depictions of violence and sex. The series has been adapted into the hit HBO television show Game of Thrones, which has become one of the most popular and critically acclaimed shows in television history. The series has also been adapted into a number of other media, including graphic novels, board games, and video games. A Song of Ice and Fire is a sprawling, epic fantasy series that explores themes of power, loyalty, and morality. It is a complex and nuanced work that has captivated readers and viewers for decades.', 'assets/images/IceFire.jpg');

  CREATE PROCEDURE GetAllBooks
AS
BEGIN
    SELECT * FROM Books
END
GO

CREATE PROCEDURE GetBookById
    @Id INT
AS
BEGIN
    SELECT * FROM Books WHERE Id = @Id
END
GO

CREATE PROCEDURE AddBook
    @Title NVARCHAR(100),
    @Author NVARCHAR(100),
    @Description NVARCHAR(MAX),
    @ImageUrl NVARCHAR(255)
AS
BEGIN
    INSERT INTO Books (Title, Author, Description, ImageUrl) VALUES (@Title, @Author, @Description, @ImageUrl)
END
GO

CREATE PROCEDURE UpdateBook
    @Id INT,
    @Title NVARCHAR(100),
    @Author NVARCHAR(100),
    @Description NVARCHAR(MAX),
    @ImageUrl NVARCHAR(255)
AS
BEGIN
    UPDATE Books SET Title = @Title, Author = @Author, Description = @Description, ImageUrl = @ImageUrl WHERE Id = @Id
END
GO

CREATE PROCEDURE DeleteBook
    @Id INT
AS
BEGIN
    DELETE FROM Books WHERE Id = @Id
END
GO

CREATE PROCEDURE GetBooksByAuthor
    @Author NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Books WHERE Author = @Author
END
GO