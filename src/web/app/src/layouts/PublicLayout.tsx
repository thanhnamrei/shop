import Avatar from '@/components/avatar';
import { Row } from '@/components/box/Row';
import { Button } from '@/components/button/Button';
import { Footer } from '@/components/footer';
import { Label } from '@/components/label';
import { Text } from '@/components/text';

type PublicLayoutProps = {
  children: React.ReactNode;
};

const View = ({ children }: PublicLayoutProps) => {
  return (
    <div>
      <header className="p-5">
        <Row gap={6} className="bg-slate-300 ">
          <Avatar />
          <Text italic>Trợ giúp</Text>
          <Text>Hệ thống cửa hàng</Text>
          <Text>English</Text>|<Text>Tiếng Việt</Text>
        </Row>
        <Row>
          <Label>This a label</Label>
        </Row>
        <Row>
          <Button className="border px-2 py-1 hover:bg-gray-200">
            This a label
          </Button>
        </Row>
      </header>
      <main>{children}</main>
      <Footer></Footer>
    </div>
  );
};
export default View;
