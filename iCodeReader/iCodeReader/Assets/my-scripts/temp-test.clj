(ns user)

(import (System.Net WebClient))
(import (System.Text Encoding))

(System.Console/WriteLine "dsfdsfdsfdsfdsfdsfdsf")

(defn foo [a b]
  (str a " " b))
  
(defn fuck []
	"sdfdsf")

(defn load-web [a]
	(.LoadUrl a "http://www.baidu.com"))