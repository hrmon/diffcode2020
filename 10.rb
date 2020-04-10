
while line = gets
    tab = Hash.new
    cc = line.strip.split(/\s+/).map(&:to_i)
    for j in 1..cc[0] do
        inp = gets.strip.split(/\s+/).map(&:to_i)
        for k in 1..(inp[0]) do
            if ! tab.has_key?(inp[k])
                tab[inp[k]] = 0
            end
            tab[inp[k]] = tab[inp[k]] + 4 - k
        end
    end
    mm = 0
    wi = []
    tab.each do |key, value|
        if value > mm
            mm = value
            wi = []
        end
        if value == mm
            wi.push(key)
        end
    end
    puts wi.sort.join(" ")
end