package exercise

import (
	"fmt"
	"strings"
)

var Links = []string{
	"https://dl.glorycartoon.com/dl/glory/Elemental.2023/Elemental.2023.1080p.BluRay.x264-GLORY_www.Glorycartoon.com_.mp4",
	"https://dl.glorycartoon.com/dl/glory/Elemental.2023/Elemental.2023.720p.BluRay.x264-GLORY_www.Glorycartoon.com_.mp4",
	"https://dl.glorycartoon.com/dl/glory/Elemental.2023/Elemental.2023.400p.BluRay.x264-GLORY_www.Glorycartoon.com_.mp4",
	"https://dl.glorycartoon.com/dl/glory/Elemental.2023/Elemental.2023.PersianSound.BluRay-GLORY_www.Glorycartoon.com_.zip",
	"https://dl.glorycartoon.com/dl/glory/Elemental.2023/Elemental.2023.Glory.Brochure.pdf",
}

type Quality struct {
	Qualities map[string]string
	Others    []string
	Best      string
	BestLink  string
}

func (q Quality) String() string {
	var builder strings.Builder

	s := fmt.Sprintf("best: %s, best_link:%s\nothers:%v\n", q.Best, q.BestLink, q.Others)
	builder.WriteString(s)

	for key, value := range q.Qualities {
		builder.WriteString(fmt.Sprintf("%s: %s\n", key, value))
	}

	return builder.String()
}

func StrategyCollection() []Strategy {
	return []Strategy{
		QualityStrategy{name: "1080p", keyword: "1080"},
		QualityStrategy{name: "720p", keyword: "720"},
		QualityStrategy{name: "480p", keyword: "480"},
		QualityStrategy{name: "400p", keyword: "400"},
		QualityStrategy{name: "360p", keyword: "360"},
		QualityStrategy{name: "DVDRip", keyword: "dvdrip"},
		QualityStrategy{name: "Brochure", keyword: "brochure"},
		AssetStrategy{name: "Audio", keyword: ""},
	}
}

type Strategy interface {
	Apply(quality *Quality, url string)
	Matches(url string) bool
}

type AssetStrategy struct {
	name    string
	keyword string
}

func (s AssetStrategy) Matches(url string) bool {
	url = strings.ToLower(url)
	return strings.Contains(url, "audio") || strings.Contains(url, "sound")
}

func (s AssetStrategy) Apply(quality *Quality, url string) {
	quality.Qualities[s.name] = url
}

type QualityStrategy struct {
	name    string
	keyword string
}

func (s QualityStrategy) Apply(quality *Quality, url string) {
	quality.Qualities[s.name] = url
	if quality.Best == "" {
		quality.Best = s.name
		quality.BestLink = url
	}
}

func (s QualityStrategy) Matches(url string) bool {
	url = strings.ToLower(url)
	return strings.Contains(url, s.keyword)
}

func DivideQualities(links []string) Quality {
	q := Quality{
		Qualities: make(map[string]string),
	}
	strategies := StrategyCollection()

	for _, url := range links {
		matched := false
		for _, strategy := range strategies {
			if strategy.Matches(url) {
				strategy.Apply(&q, url)
				matched = true
				break
			}
		}

		if !matched {
			q.Others = append(q.Others, url)
		}
	}

	return q
}
