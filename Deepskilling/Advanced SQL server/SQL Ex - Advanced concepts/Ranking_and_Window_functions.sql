
-- 1. ROW_NUMBER()

SELECT * 
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;


-- 2. RANK()

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RankNum
    FROM Products
) AS RankedProducts
WHERE RankNum <= 3;


-- 3. DENSE_RANK()

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS DenseRankNum
    FROM Products
) AS RankedProducts
WHERE DenseRankNum <= 3;