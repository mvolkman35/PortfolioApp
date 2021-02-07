CREATE DATABASE portfolio_app;

use portfolio_app;

CREATE TABLE holdings
(
	ticker 		VARCHAR(6)      PRIMARY KEY 	NOT NULL 		UNIQUE,
    quantity 	DECIMAL(13,2)	NOT NULL 		DEFAULT 0
);

CREATE TABLE transactions
(
	trans_id 		INT 			PRIMARY KEY 	auto_increment,
    trade_action 	VARCHAR(4)		NOT NULL,
	ticker 			VARCHAR(6)		NOT NULL,
    quantity_change DECIMAL(13,2)	NOT NULL 		DEFAULT 0,
    trade_price		DECIMAL(13,2)	NOT NULL		DEFAULT 0,
    cash_amount 	DECIMAL(13,2)	NOT NULL		DEFAULT 0,
    CONSTRAINT transactions_fk_holdings
		FOREIGN KEY (ticker) REFERENCES holdings (ticker) 
		ON DELETE CASCADE
);

INSERT into holdings VALUES ('TSLA', 5);
INSERT into transactions 
	(trade_action, ticker, quantity_change, trade_price, cash_amount)
VALUES ('BUY','AAPL', 10, 1000, 5000);
DELETE FROM holdings WHERE ticker = 'TSLA';