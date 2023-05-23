import Avatar from '@/components/avatar';
import { Container } from '@/components/box/Container';
import { Row } from '@/components/box/Row';
import Button from '@/components/button/Button';
import { Footer } from '@/components/footer';
import SearchBar from '@/components/form/input/SearchBar';
import { Label } from '@/components/label';
import { Text } from '@/components/text';

type PublicLayoutProps = {
  children: React.ReactNode;
};

const View = ({ children }: PublicLayoutProps) => {
  return (
    <Container>
      <header className="p-5">
        <Row
          gap={6}
          mainAxisAlignment="end"
          className="bg-slate-300 "
        >
          <Text italic>Trợ giúp</Text>
          <Text>Hệ thống cửa hàng</Text>
          <Text>English</Text>|<Text>Tiếng Việt</Text>
        </Row>
        <Row>
          <Avatar name="LV" />
          <SearchBar />
          <Button>Favorite</Button>
          <Button>Avatar</Button>
          <Button>Cart</Button>
        </Row>
      </header>
      <main>{children}</main>
      <Footer></Footer>
    </Container>
  );
};
export default View;
