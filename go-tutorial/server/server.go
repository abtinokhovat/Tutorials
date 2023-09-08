package main

import (
	"encoding/base64"
	"fmt"
	"net/http"
	"os"
)

func readFile() []byte {
	content, err := os.ReadFile("test.txt")
	if err != nil {
		return nil
	}
	return content
}

func b64(str []byte) string {
	return base64.StdEncoding.EncodeToString(str)
}

func getTextHandler(w http.ResponseWriter, r *http.Request) {
	content := readFile()
	text := b64(content)
	fmt.Println(text)
	fmt.Fprintf(w, text)
	fmt.Println("Sent to", ReadUserIP(r))
}

func ReadUserIP(r *http.Request) string {
	IPAddress := r.Header.Get("X-Real-Ip")
	if IPAddress == "" {
		IPAddress = r.Header.Get("X-Forwarded-For")
	}
	if IPAddress == "" {
		IPAddress = r.RemoteAddr
	}
	return IPAddress
}

func main() {
	http.HandleFunc("/", getTextHandler)

	port := "8080"
	fmt.Printf("Server running on port %s...\n", port)
	err := http.ListenAndServe(":"+port, nil)
	if err != nil {
		panic(err)
	}

}
