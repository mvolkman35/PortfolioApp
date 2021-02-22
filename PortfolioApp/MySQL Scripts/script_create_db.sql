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

CREATE TABLE stock_profile
(
	company_description 		VARCHAR(255) 	PRIMARY KEY UNIQUE,
	ticker 						VARCHAR(6)		NOT NULL	UNIQUE,
    asset_type					VARCHAR(255)	NOT NULL,
    last_price					DECIMAL(13,2)	NOT NULL	DEFAULT 0,
    CONSTRAINT stock_profile_fk_holdings
		FOREIGN KEY (ticker) REFERENCES holdings (ticker) 
		ON DELETE CASCADE
);

/* Add CASH to build, always have cash*/
INSERT into holdings VALUES ('CASH', 10000);
INSERT into stock_profile VALUES ('Cash Total', 'CASH', 'Cold Hard Cash', 1);
