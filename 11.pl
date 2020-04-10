use warnings;
use strict;

my $no = <STDIN>;
my $socks = <STDIN>;
my @so = split ' ', $socks;
my @count = (-1) x 500;
my @res = ();

foreach my $i (0..($#so)) {
    if ( $count[$so[$i]] >= 0 ){
        my @tmp = ($count[$so[$i]]+1, $i+1);
        push(@res, \@tmp);
        $count[$so[$i]] = -1;
    } else {
        $count[$so[$i]] = $i;
    }
}
my @out = sort { $a->[0] <=> $b->[0] } @res;
print $#out +1;
foreach my $t (@out) {
    print("\n");
    print join(" ", @{$t});
}